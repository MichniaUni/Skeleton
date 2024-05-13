using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
        
    [TestClass]
    public class tstStock
    {
        /******************GOOD TEST DATA******************/
        string ItemDescription = "RedDrones";
        string RestockDate = DateTime.Now.ToShortDateString();
        string QuantityInStock = "21";
        string ItemPrice = "1.23";


        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //test to see taht is there
            Assert.IsNotNull(AnStock);
        }

        /******************PROPERTY OK TESTS******************/

        [TestMethod]
        public void IsActivePropertyOK()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStock.IsActive = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.IsActive, TestData);
        }

        [TestMethod]
        public void RestockDatePropertyOK()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.RestockDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.RestockDate, TestData);
        }

        [TestMethod]
        public void ItemIDPropertyOK()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.ItemID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ItemID, TestData);
        }

        [TestMethod]
        public void QuantityInStockPropertyOK()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.QuantityInStock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.QuantityInStock, TestData);
        }

        [TestMethod]
        public void ItemDescriptionPropertyOK()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Some Stock";
            //assign the data to the property
            AnStock.ItemDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ItemDescription, TestData);
        }

        [TestMethod]
        public void ItemPricePropertyOK()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            decimal TestData = 1.00M;
            //assign the data to the property
            AnStock.ItemPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ItemPrice, TestData);
        }

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ItemID = 21;
            //invoke the method
            Found = AnStock.Find(ItemID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY FOUND TESTS******************/

        [TestMethod]
        public void TestItemIDFound()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemID = 21;
            //invoke the method
            Found = AnStock.Find(ItemID);
            //check the ItemID
            if (AnStock.ItemID !=21)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRestockDateFound()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemID = 20;
            //invoke the method
            Found = AnStock.Find(ItemID);
            //check the ItemID
            if (AnStock.RestockDate != Convert.ToDateTime("23/12/2020"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityInStockFound()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemID = 20;
            //invoke the method
            Found = AnStock.Find(ItemID);
            //check the ItemID
            if (AnStock.QuantityInStock != 20)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemDescriptionFound()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemID = 20;
            //invoke the method
            Found = AnStock.Find(ItemID);
            //check the ItemID
            if (AnStock.ItemDescription != "RedDrone")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsActiveFound()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemID = 20;
            //invoke the method
            Found = AnStock.Find(ItemID);
            //check the ItemID
            if (AnStock.IsActive != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemPriceFound()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemID = 20;
            //invoke the method
            Found = AnStock.Find(ItemID);
            //check the ItemID
            if (AnStock.ItemPrice != 1.23m)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
          
        }
    }
}
