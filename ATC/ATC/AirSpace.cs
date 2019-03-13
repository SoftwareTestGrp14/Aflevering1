using System;
using System.Collections.Generic;
using System.Text;

namespace ATC
{
    class AirSpace : IAirSpace
    {
        public double MinAltitude { get; set; }
        public double MaxAltitude { get; set; }
        public double xSideLength { get; set; }
        public double xStartPoint { get; set; }
        public double ySideLength { get; set; }
        public double yStartPoint { get; set; }
        public double GetXEndPoint()
        {
            return xStartPoint + xSideLength;
        }

        public double GetYEndPoint()
        {
            return yStartPoint + ySideLength;
        }
    }
}
