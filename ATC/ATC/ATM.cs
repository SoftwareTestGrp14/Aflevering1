using System;
using System.Collections.Generic;
using System.Text;


namespace ATC
{
    public class ATM
    {
        private IAirSpace airSpace;
        private IPlaneTracker planeTracker;


        public ATM(IAirSpace AirSpace, IPlaneTracker plane)
        {
            airSpace = AirSpace;
            planeTracker = plane;

            TransponderReceiver.Receiver.TransponderDataReady += Receiver_TransponderDataReady;
        }

        private void Receiver_TransponderDataReady(object sender, global::TransponderReceiver.RawTransponderDataEventArgs e)
        {


            planeTracker.Update(e.TransponderData.ToString());


        }
    }
}
