using ATC;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    public class TestILogger
    {
        private ILogger _uut;

        [Setup]
        public void Setup()
        {
            _uut = new FileLog();
        }




    }
}
