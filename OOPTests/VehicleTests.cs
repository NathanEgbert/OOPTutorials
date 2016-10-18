using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPTutorial;
using System.Diagnostics;
using OOPTutorial.Vehicles;

namespace OOPTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void VehicleTests()
        {
            Vehicle vehicle = new Vehicle
            {
                Color = "Red",
                Doors = 4,
                Engine = new Engine
                {
                    FuelEconomy = 30,
                    FuelType = "Unleaded",
                    Horsepower = 550
                },
                Lights = 4,
                Make = "Acura",
                Model = "NSX",
                NumberOfPassengers = 2,
                Wheels = 4,
                YearBuilt = "2016"
            };

            Assert.AreEqual("Red", vehicle.Color);
            Assert.AreEqual(4, vehicle.Doors);
            Assert.AreEqual(30, vehicle.Engine.FuelEconomy);
            Assert.AreEqual("Unleaded", vehicle.Engine.FuelType);
            Assert.AreEqual(550, vehicle.Engine.Horsepower);
            Assert.AreEqual(4, vehicle.Lights);
            Assert.AreEqual("Acura", vehicle.Make);
            Assert.AreEqual("NSX", vehicle.Model);
            Assert.AreEqual(2,vehicle.NumberOfPassengers);
            Assert.AreEqual(4,vehicle.Wheels);
            Assert.AreEqual("2016",vehicle.YearBuilt);
            
            

            
            
        }
    }
}
