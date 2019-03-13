using System;
using System.Collections.Generic;
using System.Text;

namespace ATC
{
    class SeparationChecker
    {
        public List<Track[]> SeparationCondition(List<Track> toCheck)
        {
            List<Track[]> conflicts = new List<Track[]>();

            for (int i = 0; i < toCheck.Count - 1; i++)
            {
                for (int j = i + 1; j < toCheck.Count - 1; j++)
                {
                    if (toCheck[i]._alt >= toCheck[j]._alt - 300 && toCheck[i]._alt <= toCheck[j]._alt + 300)
                    {

                        if ()
                    }

                }
            }





            return ;
        }
    }
}
