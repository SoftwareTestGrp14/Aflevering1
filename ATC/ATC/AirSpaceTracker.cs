using System;
using System.Collections.Generic;
using System.Text;

namespace ATC
{
    class AirSpaceTracker : IAirSpaceTracker
    {
        public bool IsInAirSpace(IAirSpace airSpace, ITrack track)
        {
            if (!track.alt >= airSpace.MinAltitude || !track.alt <= airSpace.MaxAltitude)
            { 
                return false;
            }

            if (!track.xCord>=airSpace.XStartPoint || !track.xCord<=airSpace.GetXEndPoint())
            {
                return false;
            }

            if (!track.yCord>=airSpace.YStartPoint || !track.yCord<=airSpace.GetYEndPoint())
            {
                return false;
            }

            return true;
        }
    }
}
