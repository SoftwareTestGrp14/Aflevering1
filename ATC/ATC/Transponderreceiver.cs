using System;
using System.Collections.Generic;
using System.Text;
using TransponderReceiver;

namespace ATC
{
    public class TransponderReceiver
    {
        
        public ITransponderReceiver Receiver = TransponderReceiverFactory.CreateTransponderDataReceiver();
        
    }

    
}
