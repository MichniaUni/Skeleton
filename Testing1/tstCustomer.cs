using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {

        /********************** INSTANCE OF THE CLASS TEST ******************/

        [TestMethod]
        public void InstanceOKc()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        /************************* PROPERTY OK TESTS ***************************/

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
            ACustomer.DateJoined = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateJoined, TestData);
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
            Int32 TestData = 144;
            //assign the data to the customer
            ACustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        /************************ FIND METHOD TEST ************************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /*************************** PROPERTY FOUND TESTS *************************/

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the CustomerID
            if (ACustomer.CustomerId != 5)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateJoinedFound()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the Customer
            if (ACustomer.DateJoined != Convert.ToDateTime("03/09/2023"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestisActiveFound()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the Customer
            if (ACustomer.isActive != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the Customer
            if (ACustomer.PhoneNumber != 786854545)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAgeFound()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the Customer
            if (ACustomer.Age != 16)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the Customer
            if (ACustomer.LastName != "Jack")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the Customer
            if (ACustomer.FirstName != "Alex")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }



    }
}
