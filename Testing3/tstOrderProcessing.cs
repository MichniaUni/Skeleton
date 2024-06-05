

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO.Pipes;
using System.Runtime.Remoting.Messaging;

namespace Testing3
{


    [TestClass]
    public class tstOrderProcessing


    {
        //good test data
        //create some test data to pass to the method
        String OrderDate = DateTime.Now.ToShortDateString();
        String OrderStatus = "pending";
        String PaymentMethod = "cash";


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
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrderProcessing.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderProcessing.OrderDate, TestData);
        }
        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            String TestData = "pending";
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
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //test to see if the result is true
            Assert.IsNotNull(Found);
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
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the OrderId
            if (AnOrderProcessing.OrderId != 1)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create 
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the DateAdded property
            if (AnOrderProcessing.OrderDate != Convert.ToDateTime("01/02/2024"))
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
            Int32 OrderId = 1;
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
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the Orderstatus property
            if (AnOrderProcessing.OrderStatus != "pending")
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
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the Orderstatus property
            if (AnOrderProcessing.PaymentMethod != "card")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instnace of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create 
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            String OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date varaible to string variable
            String OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date varaible to string variable
            String OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date varaible to string variable
            String OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date varaible to string variable
            String OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string variable to store any error message
            String Error = "";
            //set the OrderDate to a non date value
            String OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void OrderStatusMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string varaible to store any error message
            String Error = "";
            //this should fail
            String OrderStatus = "";
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderStatusMin()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string varaible to store any error message
            String Error = "";
            //this should pass
            String OrderStatus = "a";
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void OrderStatusMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string varaible to store any error message
            String Error = "";
            //this should pass
            String OrderStatus = "aa";
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void OrderStatusMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string varaible to store any error message
            String Error = "";
            //this should pass
            String OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(49, 'a');
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void OrderStatusMax()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string varaible to store any error message
            String Error = "";
            //this should pass
            String OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(50, 'a');
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string varaible to store any error message
            String Error = "";
            //this should fail
            String OrderStatus = "";
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderStatusMid()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string varaible to store any error message
            String Error = "";
            //this should pass
            String OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(25, 'a');
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PaymentMethodMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string varaible to store any error message
            String Error = "";
            //this should fail
            String PaymentMethod = "";
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PaymentMethodMin()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string varaible to store any error message
            String Error = "";
            //this should pass
            String PaymentMethod = "a";
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PaymentMethodMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string varaible to store any error message
            String Error = "";
            //this should pass
            String PaymentMethod = "aa";
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PaymentMethodMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string varaible to store any error message
            String Error = "";
            //this should pass
            String PaymentMethod = "";
            PaymentMethod = PaymentMethod.PadRight(49, 'a');
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PaymentMethodMax()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string varaible to store any error message
            String Error = "";
            //this should pass
            String PaymentMethod = "";
            PaymentMethod = PaymentMethod.PadRight(50, 'a');
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PaymentMethodMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string varaible to store any error message
            String Error = "";
            //this should fail
            String PaymentMethod = "";
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PaymentMethodMid()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string varaible to store any error message
            String Error = "";
            //this should pass
            String PaymentMethod = "";
            PaymentMethod = PaymentMethod.PadRight(25, 'a');
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
    }
}
