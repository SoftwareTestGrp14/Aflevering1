using System;
using System.Collections.Generic;
using System.Text;

namespace ATC
{
    class Track : ITrack
    {
        public Track(string tag, int xC, int yC, int alt, int vel, int course, DateTime ts)
        {
            _tag = tag;
            _xCord = xC;
            _yCord = yC;
            _alt = alt;
            _velocity = vel;
            _course = course;
            _timestamp = ts;
        }

        string _tag { get; set; }
        private int _xCord { get; set; }
        private int _yCord { get; set; }
        private int _alt { get; set; }
        private int _velocity { get; set; }
        private int _course { get; set; }
        private DateTime _timestamp { get; set; }
    }
}
