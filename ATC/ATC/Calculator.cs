using System;
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

        public static int CalcCourse(int xCord1, int xCord2, int yCord1, int yCord2)
        {
            int xDiff = xCord2 - xCord1;
            int yDiff = yCord2 - yCord1;
            double distance = Math.Sqrt(Math.Pow(yDiff, 2) + Math.Pow(xDiff, 2));

            return Math.Asin(yDiff / distance);
        }

    }
}
