using ATC;
using NUnit.Framework;

namespace UnitTests
{
    public class TestSeparationCondition
    {
        private SeparationCondition _uut;
        private ITrack _fakeTrack1;
        private ITrack _fakeTrack2;

        [SetUp]
        public void Setup()
        {
          
    
            _uut = new SeparationCondition();
        }

        [Test]
        public void Test1()
        {

            Assert.Pass();
        }
    }
}