using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPTutorial;

namespace OOPTests
{
    [TestClass]
    public class BoatTests
    {
        [TestMethod]
        public void BoatLengthTest()
        {

            Boat boatOne = new Boat()
            {
                BoatLength = "32ft",
                Make = "Bass Tracker",
               
            };


        }
    }
}
