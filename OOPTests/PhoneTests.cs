using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPTutorial;

namespace OOPTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void PhoneTests()
        {
            
            CellPhone cellPhone = new CellPhone
            {
                type = "Iphone",
                model = "7",
                color = "Space Grey",
                storage = "64gb",
                carrier = "Verison"
            };

            Assert.AreEqual("Iphone", cellPhone.type);
            Assert.AreEqual("7", cellPhone.model);
            Assert.AreEqual("Space Grey",cellPhone.color);
            Assert.AreEqual("64gb", cellPhone.storage);


            //testing the this.type
            string oldCellPhoneType = "Android";
            string cellPhoneType = cellPhone.GetPhoneType(oldCellPhoneType);
            Assert.AreEqual("Iphone", cellPhoneType);



        }
    }
}
