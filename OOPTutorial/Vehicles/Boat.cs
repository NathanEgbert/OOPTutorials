using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial
{
    public class Boat : Vehicle,IVehicle
    {
       

        public string BoatLength { get; set; }

        public int EngineSize { get; set; }

        public bool TwoStroke { get; set; }

        public bool FourStroke { get; set; }


        

        /// <summary>
        /// Describes the Vehicle
        /// In this case it describes a boat
        /// </summary>
        /// <returns></returns>
        public string DescribeVehicle()
        {

            return "Boat";

        }

        /// <summary>
        /// Describes the Engine
        /// In this case it is a boat engine
        /// </summary>
        /// <returns></returns>
       public  string DescribeEngine()
        {
            if (TwoStroke == true)
            {
                return "Two Stroke";
            }
            else if (FourStroke == true)
            {
                return "Four Stroke";
            }
            else
                return "Unknown engine type"; 

        }

    }

   public  class BoatEngine
    {

        public string Make { get; set; }

        public int EngineSize { get; set; }

        public bool Inboard { get; set; }

        public bool OutBoard { get; set; }

        public bool TwoStroke { get; set; }

        public bool FourStroke { get; set; }

        public string Year { get; set; }

    }
}
