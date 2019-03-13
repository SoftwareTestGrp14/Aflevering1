﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ATC
{
    public static class Calculator
    {
        public static double CalcVelocity(int xCord1, int xCord2, int yCord1, int yCord2, DateTime time1, DateTime time2)
        {
            TimeSpan timeDiff = time2.Subtract(time1);
            int xDiff = xCord2 - xCord1;
            int yDiff = yCord2 - yCord1;
            double distance = Math.Sqrt(Math.Pow(yDiff, 2) + Math.Pow(xDiff, 2));
            
            return distance / timeDiff.TotalSeconds;
        }

        public static double CalcCourse(int xCord1, int xCord2, int yCord1, int yCord2)
        {
            int xDiff = xCord2 - xCord1;
            int yDiff = yCord2 - yCord1;
            double distance = Math.Sqrt(Math.Pow(yDiff, 2) + Math.Pow(xDiff, 2));

            return Math.Asin(yDiff / distance);
        }

        public static bool IsSeparation(Track track1, Track track2)
        {
            if (track1._alt <= (track2._alt + 300) && track1._alt >= (track2._alt - 300))
            {
                int xDiff = track1._xCord - track2._xCord;
                int yDiff = track1._yCord - track2._yCord;
                double separation = Math.Sqrt(Math.Pow(yDiff, 2) + Math.Pow(xDiff, 2));
                if (separation <= 5000)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
