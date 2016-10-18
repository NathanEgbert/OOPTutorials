using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial.Vehicles
{
    public class Car :Vehicle,IVehicle
    {
      public string DescribeVehicle()
        {
            return "Test";
        }

      public string DescribeEngine()
        {
            return "test";
        }
    }
}
