using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Text;

namespace ATC
{
    public class PlaneTracker : IPlaneTracker
    {
        
        private List<ITrack> tracks;
        private SeparationChecker sepCheck;
        private IAirSpaceTracker airSpaceTracker;
        private IAirSpace airSpace;
        private List<string[]> tempDataList;
        private List<SeparationCondition> currentSeparations;

        public PlaneTracker()
        {
            airSpaceTracker= new AirSpaceTracker();
            airSpace = new AirSpace();
        }



        public void Update(string data)
        {
            double vel=0;
            double course=0;
            string[] newData = ConvertTransponderData(data);

            bool dataExists = false;

            int i = 0;
            foreach (var AircraftName in tempDataList)
            {
                if (AircraftName[0] == newData[0])
                {

                    vel = CalcVelocity(int.Parse(tempDataList[i][1]), int.Parse(newData[1]), int.Parse(tempDataList[i][2]), int.Parse(newData[2]), DateTime.Parse(tempDataList[i][4]), DateTime.Parse(newData[4]));
                    course = CalcCourse(int.Parse(tempDataList[i][1]), int.Parse(newData[1]), int.Parse(tempDataList[i][2]), int.Parse(newData[2]), DateTime.Parse(tempDataList[i][4]), DateTime.Parse(newData[4]));
                    tempDataList[i] = newData;
                    dataExists = true;
                }

                i++;
            }

            if (!dataExists)
            {
                tempDataList.Add(newData);
            }

                ITrack newTrack = new Track(newData[0], int.Parse(newData[1]), int.Parse(newData[2]), int.Parse(newData[3]), vel , course, DateTime.Parse(newData[4]));


                if (airSpaceTracker.IsInAirSpace(airSpace, newTrack) && !tracks.Contains(newTrack))
                {
                    tracks.Add(newTrack);
                }
                else if (tracks.Contains(newTrack))
                {
                    tracks.Remove(newTrack);

                }

                foreach (var curTrack in tracks)
                {
                    if (IsSeparation(curTrack, newTrack))
                    {
                        SeparationCondition newSeparationCondition = new SeparationCondition(curTrack, newTrack);
                        // Check om der i forvejen er en separation og override denne med den nye
                        
                    
                        currentSeparations.Add(newSeparationCondition);
                        //Write to file
                    }
                    else
                    {
                        
                    }
                }




        }

        public string[] ConvertTransponderData(string data)
        {
            

            string[] separatedData = data.Split(new string[] { "; " }, StringSplitOptions.None);


            return separatedData;
        }

        
        public bool CheckSeparation(List<ITrack> tracks)
        {
            sepCheck.isSeparationCondition(tracks);
        }
        
    }
}
