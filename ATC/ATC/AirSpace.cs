using System;
using System.Collections.Generic;
using System.Text;

namespace ATC
{
    class AirSpace : IAirSpace
    {
        public double MinAltitude { get; set; }
        public double MaxAltitude { get; set; }
        public double XSideLength { get; set; }
        public double XStartPoint { get; set; }
        public double YSideLength { get; set; }
        public double YStartPoint { get; set; }
        public double GetXEndPoint()
        {
            return XStartPoint + XSideLength;
        }

        public double GetYEndPoint()
        {
            return YStartPoint + YSideLength;
        }
    }
}
