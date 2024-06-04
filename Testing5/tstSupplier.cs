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
            Int32 TestData = 3;
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
            string TestData = "Test";
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
            Int32 TestData = 10;
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
            decimal TestData= 120.00M;
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


        /*** FIND****/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the clsSupplier
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create test data to use thid method
            Int32 SupplierID = 3;
            //invoke the method
            Found= AnSupplier.Find(SupplierID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestSupplierIDFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK= true;
            //create some test data to use with method
            Int32 SupplierID = 3;
            //invoke the method
            Found = AnSupplier.Find(SupplierID);
            //check the supplierid
            if (AnSupplier.SupplierID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductionDateFound()
        {
            // create an instance of the clsSupplier
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found= false;
            // create a Boolean variable to record if the data is OK
            Boolean OK= true;
            //create some tests data to use with the mwthod
            Int32 SupplierID = 3;
            //invoke the method
            Found = AnSupplier.Find(SupplierID);
            //check the productiondate property
            if (AnSupplier.ProductionDate != Convert.ToDateTime("06/12/2002"))
            {
                OK= false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public  void TestSupplierNameFound()
        { 
            // create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
           //create boolean variable to store the result of the search
            Boolean Found= false;
            //create boolean variable to record if data is OK

            Boolean OK= true;
            //create some tests data to use with the method
            Int32 SupplierID= 3;
            //invoke the method
            Found=AnSupplier.Find(SupplierID);
            //check the Supplier Name property
            if (AnSupplier.SupplierName !="Test")
            {
                OK= false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestShipmentStatusFound()
        {
            // create an imnstance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
           // create a boolean variable to store the result of the search
            Boolean Found= false;
            //create boolean variable to record if the data is OK
            Boolean OK= true;
            //create test fata to use with the method
            Int32 SupplierID= 3;
            //invoke the methgod
            Found =AnSupplier.Find(SupplierID);
            //check shipmentstatus property
            if (AnSupplier.Shipmentstatus != true)
            {
                OK= false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestQuantityFound()
        { 
            //create an instance of the class you want
            clsSupplier AnSupplier = new clsSupplier();
            //create boolean variable to store the result of the search
        Boolean Found= false;
            //create a boolean variable to record if data id PK
        Boolean OK= true;
            //create some test dat to use with the method
         Int32 SupplierID= 3;
         //invoke the method
         Found =AnSupplier.Find(SupplierID);
            //check the Quantity property
            if (AnSupplier.Quantity != 10 )
            {
                OK= false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestExpiryDateFound()
        {
            // create an instance of the clsSupplier
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            // create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some tests data to use with the mwthod
            Int32 SupplierID = 3;
            //invoke the method
            Found = AnSupplier.Find(SupplierID);
            //check the productiondate property
            if (AnSupplier.ExpiryDate != Convert.ToDateTime("06/12/2004"))
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestPriceFound()
        { 
            //create an instanc of cls suplier
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            // create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some tests data to use with the method
            Int32 SupplierID = 3;
            //invoke the method
            Found = AnSupplier.Find(SupplierID);
            //check the price property
            if (AnSupplier.Price!= 120.00m)
            {
                OK= false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
                    }

    }
}

