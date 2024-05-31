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
        public void ItemIdPropertyOK()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.ItemId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ItemId, TestData);
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
            Int32 ItemId = 1;
            //invoke the method
            Found = AnStock.Find(ItemId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY FOUND TESTS******************/

        [TestMethod]
        public void TestItemIdFound()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 1;
            //invoke the method
            Found = AnStock.Find(ItemId);
            //check the ItemId
            if (AnStock.ItemId !=1)
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
            Int32 ItemId = 1;
            //invoke the method
            Found = AnStock.Find(ItemId);
            //check the ItemId
            if (AnStock.RestockDate != Convert.ToDateTime("10/05/2024"))
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
            Int32 ItemId = 1;
            //invoke the method
            Found = AnStock.Find(ItemId);
            //check the ItemId
            if (AnStock.QuantityInStock != 10)
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
            Int32 ItemId = 1;
            //invoke the method
            Found = AnStock.Find(ItemId);
            //check the ItemId
            if (AnStock.ItemDescription != "BlueDrone")
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
            Int32 ItemId = 1;
            //invoke the method
            Found = AnStock.Find(ItemId);
            //check the ItemId
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
            Int32 ItemId = 1;
            //invoke the method
            Found = AnStock.Find(ItemId);
            //check the ItemId
            if (AnStock.ItemPrice != 125.000m)
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

        /******************PARAMETER TEST ItemDescription******************/

        [TestMethod]
        public void ItemDescriptionMinLessOne()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemDescription = "";
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMin()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemDescription = "*";
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMinPlusOne()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemDescription = "**";
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMaxLessOne()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadLeft(49, '*');
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMax()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadLeft(50, '*');
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMid()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadLeft(25, '*');
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMaxPlusOne()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadLeft(51, '*');
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionExtremeMax()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadLeft(1000, '*');
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /******************PARAMETER TEST RestockDate******************/


        [TestMethod]
        public void RestockDateExtremeMin()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime  TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //change the date to TestDate less 100years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string RestockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RestockDateMinLessOne()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //change the date to TestDate less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string RestockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RestockDateMin()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string RestockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RestockDateMinPlusOne()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //change the date to TestDate plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string RestockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RestockDateMaxLessOne()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //change the date to TestDate plus 364 days
            TestDate = TestDate.AddDays(364);
            //convert the date variable to a string variable
            string RestockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RestockDateMax()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //change the date to TestDate plus 365 days
            TestDate = TestDate.AddDays(365);
            //convert the date variable to a string variable
            string RestockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RestockDateMaxPlusOne()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //change the date to TestDate plus 366 days
            TestDate = TestDate.AddDays(366);
            //convert the date variable to a string variable
            string RestockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RestockDateMid()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //change the date to TestDate plus 182 days
            TestDate = TestDate.AddDays(182);
            //convert the date variable to a string variable
            string RestockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RestockDateExtremeMax()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //change the date to TestDate plus 100years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string RestockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RestockDateInvalidData()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the RestockDate to a non date value
            string RestockDate = "this is not a date!";
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /******************PARAMETER TEST QuantityInStock******************/

        [TestMethod]
        public void QuantityInStockExtremeMin()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string QuantityInStock = "-10000000";
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInStockMinLessOne()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string QuantityInStock = "-1";
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInStockMin()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string QuantityInStock = "0";
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInStockMinPlusOne()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string QuantityInStock = "1";
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInStockInvalidData()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the QuantityInStock to a non date value
            string QuantityInStock = "this is not a value!";
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /******************PARAMETER TEST ItemPrice******************/

        [TestMethod]
        public void ItemPriceExtremeMin()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemPrice = "-10000000";
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMinLessOne()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemPrice = "-0.01";
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMin()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemPrice = "0.00";
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMinPlusOne()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemPrice = "0.01";
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceInvalidData()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the ItemPrice to a non date value
            string ItemPrice = "this is not a value!";
            //invoke the method
            Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
