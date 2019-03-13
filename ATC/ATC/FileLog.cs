using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ATC
{
    public class FileLog : ILogger
    {
        public void Write(string textString)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
               w.WriteLine(textString);
            }

        }
    }
}
