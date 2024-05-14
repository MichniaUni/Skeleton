using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstShipment
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //test to see that it exists
            Assert.IsNotNull(AnShipment);
        }
    }

}
