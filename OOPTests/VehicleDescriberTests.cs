using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPTutorial.Vehicles;
using OOPTutorial;

namespace OOPTests
{
    [TestClass]
    public class VehicleDescriberTests
    {
        [TestMethod]
        public void DescirbeVehicleTests()
        {

            Vehicle car = new Vehicle();
            VehicleDescriber describeCar = new VehicleDescriber();

            car.NumberOfPassengers = 5;
            car.Wheels = 4;
            car.YearBuilt = "2016";

            string carType = describeCar.DescribeVehicle(car);

            Assert.AreEqual("Multi Passenger Vehicle", carType);

        }

        [TestMethod]
        public void DescribeEngineTests()
        {
           
            VehicleDescriber describeEngine = new VehicleDescriber();

            Vehicle natesCar = new Vehicle
            {
                Color = "Black",
                Doors = 4,
                Engine = new Engine
                {
                    FuelEconomy = 30,
                    FuelType = "Deisel",
                    Horsepower = 550
                },
                Lights = 4,
                Make = "Honda",
                Model = "Civic",
                NumberOfPassengers = 4,
                Wheels = 4,
                YearBuilt = "2016"
            };

            string engineType = describeEngine.DescribeEngine(natesCar);


            Assert.AreEqual("Expensive gas", engineType);
        }
    }
}
