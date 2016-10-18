using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPTutorial;

namespace OOPTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BoatTests()
        {
            Boat boat = new Boat
            {
                Make = "Bass Tracker",
                
                Engine = new BoatEngine
                {
                    Make = "Yamaha",
                    EngineSize = 250,
                    Inboard = false,
                    OutBoard = true,
                    TwoStroke = false,
                    FourStroke = true,
                    Year = "2016"  
                },

                Year = "2016",
                BoatLength = "32ft"

            };

            Assert.AreEqual("Bass Tracker", boat.Make);
            Assert.AreEqual("Yamaha", boat.Engine.Make);
            Assert.AreEqual(250,boat.Engine.EngineSize);
            Assert.AreEqual(false,boat.Engine.Inboard);
            Assert.AreEqual(true, boat.Engine.OutBoard);
            Assert.AreEqual(false, boat.Engine.TwoStroke);
            Assert.AreEqual(true, boat.Engine.FourStroke);
            Assert.AreEqual("2016", boat.Engine.Year);
            Assert.AreEqual("32ft",boat.BoatLength);


        }
    }
}
