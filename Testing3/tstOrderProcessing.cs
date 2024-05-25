

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO.Pipes;

namespace Testing3
{
    [TestClass]
    public class tstOrderProcessing
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //test to see that it exists
            Assert.IsNotNull(AnOrderProcessing);

        }
        [TestMethod]
        public void IsCancelledPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data of the property
            AnOrderProcessing.IsCancelled = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrderProcessing.IsCancelled, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrderProcessing.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderProcessing.DateAdded, TestData);
        }
        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            String TestData = "Nawaraj";
            //assign the data to the property
            AnOrderProcessing.OrderStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderProcessing.OrderStatus, TestData);
        }
        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderProcessing.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderProcessing.OrderId, TestData);
        }
        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create some test data to asign to the property
            string TestData = "Card";
            //assign the data to the property
            AnOrderProcessing.PaymentMethod = TestData;
            //test  to see that the two values are the same
            Assert.AreEqual(AnOrderProcessing.PaymentMethod, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the classs we want to create 
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 123;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create 
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 123;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the OrderId
            if (AnOrderProcessing.OrderId != 123)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create 
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 123;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the DateAdded property
            if (AnOrderProcessing.DateAdded != Convert.ToDateTime("15/05/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestIsCancelledFound()
        {
            //create an istance of the class we want to create 
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean varaible to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 123;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the is cancelled property
            if (AnOrderProcessing.IsCancelled != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderStatusFound()
        {
            //create an istance of the class we want to create 
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean varaible to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 123;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the Orderstatus property
            if (AnOrderProcessing.OrderStatus != "Test OrderStatus")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPaymentMethodFound()
        {
            //create an istance of the class we want to create 
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean varaible to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 123;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the Orderstatus property
            if (AnOrderProcessing.PaymentMethod != "Test PaymentMethod")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
