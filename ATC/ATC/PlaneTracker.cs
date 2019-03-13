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
        
        public void Update(string data)
        {
            string[] separatedData = ConvertTransponderData(data);
            
            ITrack newTrack = new Track(separatedData[0], separatedData[1], separatedData[2], separatedData[3], separatedData[4], separatedData[5]);

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
