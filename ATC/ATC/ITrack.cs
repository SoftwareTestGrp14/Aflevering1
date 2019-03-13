using System;
using System.Collections.Generic;
using System.Text;

namespace ATC
{
    public interface ITrack
    {
        string _tag { get; }
        int _xCord { get; }
        int _yCord { get; }
        int _alt { get; }
        int _velocity { get; }
        int _course { get; }
        DateTime _timestamp { get; }
    }
}
