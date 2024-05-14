using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOKc()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void isActiveCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the customer 
            Boolean TestData = true;
            //assign the data to the property 
            ACustomer.isActive = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.isActive, TestData);
        }

        [TestMethod]
        public void DateJoinedCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the customer
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the customer
            ACustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void PhoneNumberCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the customer
            Int64 TestData = 07123456789;
            //assign the data to the customer
            ACustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void AgeCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the customer
            Int64 TestData = 20;
            //assign the data to the customer
            ACustomer.Age = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Age, TestData);
        }

        [TestMethod]
        public void LastNameCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the customer
            string TestData = "Ahmed";
            //assign the data to the customer
            ACustomer.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        [TestMethod]
        public void FirstNameCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the customer
            string TestData = "Alina";
            //assign the data to the customer
            ACustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void CustomerIdCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the customer
            Int64 TestData = 144;
            //assign the data to the customer
            ACustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }













    }
}
