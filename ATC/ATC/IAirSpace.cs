using System;
using System.Collections.Generic;
using System.Text;

namespace ATC
{
    interface IAirSpace
    {
        double MinAltitude { get; set; }
        double MaxAltitude { get; set; }
        double xSideLength { get; set; }
        double xStartPoint { get; set; }
        double ySideLength { get; set; }
        double yStartPoint { get; set; }
        double GetXEndPoint();
        double GetYEndPoint();
    }
}
