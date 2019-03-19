﻿using ATC;
using NUnit.Framework;
using NSubstitute;

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
            _fakeTrack1 = Substitute.For<ITrack>("ATR423", 39045, 12932, 140000, 20151006213456789);
            _fakeTrack2 = Substitute.For<ITrack>("BTU423", 30000, 15000, 100000, 20151006213456789);


            _uut = new SeparationCondition(_fakeTrack1, _fakeTrack2);
        }

        [Test]
        public void TestEqualsMethod()
        {
            

            //Assert.That();
        }
    }
}