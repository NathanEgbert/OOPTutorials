using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial.Vehicles
{
  public  class Truck : Vehicle,IVehicle
    {

      public string BedLength { get; set; }


      public string DescribeVehicle()
        {
            return "truck";
        }

       public  string DescribeEngine()
        {
            return Engine.Horsepower.ToString();
        }

    }
}
