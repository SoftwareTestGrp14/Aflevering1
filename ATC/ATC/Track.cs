using System;
using System.Collections.Generic;
using System.Text;

namespace ATC
{
    class Track: ITrack
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

        private string _tag { get; }
        private int _xCord { get; }
        private int _yCord { get; }
        private int _alt { get; }
        private int _velocity { get; }
        private int _course { get; }
        private DateTime _timestamp { get; }
    }
}
