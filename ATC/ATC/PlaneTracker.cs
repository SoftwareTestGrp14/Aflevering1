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
        string[] tempData=null;

        public void Update(string data)
        {

            string[] newData = ConvertTransponderData(data);




            tempData = newData;
            

            ITrack newTrack = new Track(newData[0], int.Parse(newData[1]), int.Parse(newData[2]), int.Parse(newData[3]), , , new DateTime(String.));

            tracks.Add(newTrack);


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
