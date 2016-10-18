using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial
{
     public class CellPhone 
    {
        public string type { get; set; }

        public string model { get; set; }

        public string color { get; set; }

        public string storage { get; set; }

        public string carrier { get; set; }



         public string GetPhoneType(string newPhoneType)
         {
             newPhoneType = this.type;
             return newPhoneType;
         }

        
        
    }
}
