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
        {
            // create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //creating test data to assign to the property
            Boolean TestData = true;
            //assign the data to property
           AnSupplier.Shipmentstatus = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnSupplier.Shipmentstatus, TestData);

        }
        [TestMethod]
        public void ProductionDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //creating test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            AnSupplier.ProductionDate = TestData;
            //test to see that two values are same
            Assert.AreEqual(AnSupplier.ProductionDate, TestData);
        }
        [TestMethod]
        public void SupplierIDPropertyOK()
        {  //create an instance of the class we want
           clsSupplier AnSupplier = new clsSupplier();
            //create test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the proverty
            AnSupplier.SupplierID= TestData;
            //test to see that two values are same
            Assert.AreEqual(AnSupplier.SupplierID, TestData);
        }
        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT
            clsSupplier AnSupplier = new clsSupplier();
            //create test data to assign to the property
            string TestData = "Some Supplier";
            //assign the data to property
            AnSupplier.SupplierName = TestData;
            //test to see that two values are same
            Assert.AreEqual(AnSupplier.SupplierName, TestData);

        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class you want
            clsSupplier AnSupplier = new clsSupplier();
            //create test data to assign the property
            Int32 TestData = 1;
            //assign the data to the property
            AnSupplier.Quantity= TestData;
            //test to see the two values are same
            Assert.AreEqual(AnSupplier.Quantity, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class you want
            clsSupplier AnSupplier = new clsSupplier();
            //create test data to assign the property
            decimal TestData= 1.00M;
            //assign the data to the property
            AnSupplier.Price = TestData;
            //test to see the two values are same
            Assert.AreEqual(AnSupplier.Price, TestData);
        }
        [TestMethod]
        public void ExpiryDateOK()
        {  
            //create an instance of the class you want
            clsSupplier AnSupplier = new clsSupplier();
            //create test data to assign thae proprty
            DateTime TestData = new DateTime();
            TestData.AddYears(+2);

            //assign the data to the property
            AnSupplier.ExpiryDate=TestData;
            //test to see two values are same
            Assert.AreEqual(AnSupplier.ExpiryDate, TestData);
                }

    }
}

