using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial
{
    public class Boat : IVehicle
    {
        public string Make { get; set; }

        public BoatEngine Engine { get; set; }

        public string BoatLength { get; set; }

        public string Year { get; set; }

        /// <summary>
        /// Describes the Vehicle
        /// In this case it describes a boat
        /// </summary>
        /// <returns></returns>
        string DescribeVehicle()
        {



        }

        /// <summary>
        /// Describes the Engine
        /// In this case it is a boat engine
        /// </summary>
        /// <returns></returns>
        string DescribeEngine()
        {

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
