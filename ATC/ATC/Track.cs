﻿using System;
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

        public string _tag { get; }
        public int _xCord { get; }
        public int _yCord { get; }
        public int _alt { get; }
        public int _velocity { get; }
        public int _course { get; }
        public DateTime _timestamp { get; }
    }
}
