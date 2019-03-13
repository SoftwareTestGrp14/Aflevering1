using System;
using System.Collections.Generic;
using System.Text;

namespace ATC
{
    public class SeparationCondition
    {
        private ITrack _track1;
        private ITrack _track2;
        private DateTime Timestamp;
        public SeparationCondition(ITrack track1, ITrack track2)
        {
            _track1 = track1;
            _track2 = track2;

            if (track2._timestamp > track1._timestamp)
                Timestamp = track2._timestamp;
            else
                Timestamp = track1._timestamp;
            
        }

    }
}
