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
    }
}
