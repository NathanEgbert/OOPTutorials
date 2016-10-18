using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPTutorial;

namespace OOPTests
{
    [TestClass]
    public class CellPoneCarrierTests
    {
        [TestMethod]
        public void CellPhoneCarrierTest()
        {
            
            CellPhoneCarrier myCarrier = new CellPhoneCarrier();
            CellPhone myPhone = new CellPhone()
            {
                carrier = "Verison",
                type = "Iphone",
                storage = "64gb",
                color = "Space Grey"
            };

            string myCarrierService = myCarrier.PhoneCarrier(myPhone);

            Assert.AreEqual("I bet your service is great", myCarrierService);

            


        }
    }
}
