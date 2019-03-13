using System;
using System.Collections.Generic;
using System.Text;

namespace ATC
{
    interface ITrack
    {
        string _tag { get; set; }
        int _xCord { get; set; }
        int _yCord { get; set; }
        int _alt { get; set; }
        int _velocity { get; set; }
        int _course { get; set; }
        DateTime _timestamp { get; set; }
    }
}
