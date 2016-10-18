using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial
{
    public class Vehicle 
    {
        public int Wheels { get; set; }

        public Engine Engine { get; set; } 

        public int Doors { get; set; }

        public int Lights { get; set; }

        public string Color { get; set; }

        public int NumberOfPassengers { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string YearBuilt { get; set; }


        string DescribeVehicle()
        {
            return "Test";
        }

        string DescribeEngine()
        {
            return "test";
        }

    }

    public class Engine
    {
        public int Horsepower { get; set; }
        public int FuelEconomy { get; set; }
        public string FuelType { get; set; }
    }
}
