using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPTutorial;

namespace OOPTests
{
    [TestClass]
    public class BoatTest
    {
        [TestMethod]
        public void BoatTests()
        {


            //ARRANGE
            

            //ACT
            Boat boat = new Boat()
            {
                BoatLength = "40ft",
                Make = "Grady White",
                CenterConsole = true,
                BEngine = new BoatEngine()
                {
                    Make = "Yamaha",
                    EngineSize = 250,
                    Inboard = false,
                    OutBoard = true,
                    TwoStroke = false,
                    FourStroke = true,
                    Year = "2015"
                },
            };

            //ASSERT
            Assert.AreEqual("Boat", boat.DescribeVehicle());
            Assert.AreEqual("Four Stroke", boat.DescribeEngine());
            Assert.AreEqual("40ft",boat.BoatLength);
            Assert.AreEqual("Grady White", boat.Make);
            Assert.AreEqual(true,boat.CenterConsole);

            Assert.AreEqual("Yamaha", boat.BEngine.Make);
            Assert.AreEqual(250, boat.BEngine.EngineSize);
            Assert.AreEqual(true,boat.BEngine.FourStroke);
            Assert.AreEqual(false,boat.BEngine.Inboard);



        }
    }
}
