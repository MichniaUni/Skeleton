using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()

        {
            //create an instance for class Supplier
            clsSupplier AnSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(AnSupplier);
        }
        [TestMethod]
        public void ShipmentstatusPropertyOK() 
        {// create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //creating test data to assign to the property
            Boolean TestData = true;
            //assign the data to property
            AnSupplier.Shipmentstatus = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnSupplier.Shipmentstatus, TestData);

        }

        
    }
}

