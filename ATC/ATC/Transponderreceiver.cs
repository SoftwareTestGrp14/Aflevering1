using System;
using System.Collections.Generic;
using System.Text;
using TransponderReceiver;

namespace ATC
{
    public static class TransponderReceiver
    {
        
        public static ITransponderReceiver Receiver = TransponderReceiverFactory.CreateTransponderDataReceiver();
        
    }

    
}
