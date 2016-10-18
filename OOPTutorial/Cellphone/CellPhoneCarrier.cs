using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial
{
   public class CellPhoneCarrier : IPhone
    {

      public string PhoneCarrier(CellPhone myCellPhone)
        {

            string carrier = myCellPhone.carrier;

            switch(carrier)
            {
                case "Sprint":
                    return "Your service must suck";
                case "Verison":
                    return "I bet your service is great";
                default:
                    return "Pre-paid";
            }

            
        }
    

    
    }
}
