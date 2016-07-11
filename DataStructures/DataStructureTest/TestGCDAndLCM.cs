using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DataStructureTest
{
    [TestClass]
    public class TestGCDAndLCM
    {
        [TestMethod]
        public void TestEuclid()
        {
           Assert.AreEqual( EuclidsAlgorithm.GetGCD(78,66),6);
        }

        [TestMethod]
        public void TestLCMWithGCD()
        {
            Assert.AreEqual(EuclidsAlgorithm.LCMUsingGCD(12, 15), 60);            
        }
    }
}
