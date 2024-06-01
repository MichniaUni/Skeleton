using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        /********************** GOOD TEST DATA ******************/
        string FirstName = "Alina";
        string LastName = "Ahmed";
        string Age = "20";
        string PhoneNumber = "07987654321";
        string DateJoined = DateTime.Now.ToShortDateString();


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

        /**************************************** VALID METHOD TESTS ***************************************/

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the mehod
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //------ATTRIBUTE: FirstName-------//
        [TestMethod]

        public void FirstName_min_less_one()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void FirstName_min_plus_one()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FirstName = "aa";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FirstName_max_less_one()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadLeft(49, 'a');
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FirstName_max()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadLeft(50, 'a');
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FirstName_mid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadLeft(25, 'a');
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FirstName_max_plus_one()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadLeft(51, 'a');
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void FirstName_max_extreme()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadLeft(1000, 'a');
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstName_min()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FirstName = "a";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        //------ATTRIBUTE: DateJoined-------//
        [TestMethod]
        public void DateJoined_Extreme_Min()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateJoined_Min_Less_One()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoined_Min()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateJoined_Min_Plus_One()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateJoined_Extreme_Max()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateJoined_Invalid_Data()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //set the DateJoined to a non date value
            string DateJoined = "Hello";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //------ATTRIBUTE: LastName-------//
        [TestMethod]

        public void LastName_min_less_one()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void LastName_min_plus_one()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string LastName = "aa";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void LastName_max_less_one()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadLeft(49, 'a');
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void LastName_max()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadLeft(50, 'a');
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void LastName_mid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadLeft(25, 'a');
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void LastName_max_plus_one()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadLeft(51, 'a');
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void LastName_max_extreme()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadLeft(1000, 'a');
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastName_min()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string LastName = "a";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }


        //------ATTRIBUTE: Age-------//

        [TestMethod]
        public void Age_Extreme_Min()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string Age = "-1000";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Age_Min_Less_One()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string Age = "0";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Age_Min()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string Age = "1";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Age_Min_Plus_One()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string Age = "2";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void Age_Max_Less_One()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Age = "149";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void Age_Max()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Age = "150";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void Age_Max_Plus_One()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Age = "151";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void Age_Mid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Age = "75";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void Age_Extreme_Max()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Age = "500";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Age_Invalid_Data()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //set the Age to a non integer value
            string Age = "Hello";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //------ATTRIBUTE: PhoneNumber-------//

        [TestMethod]
        public void PhoneNumber_Extreme_Min()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "-7";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumber_Min_Less_One()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "6999999999";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumber_Min()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "7000000000";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumber_Min_Plus_One()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "7000000001";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PhoneNumber_Max_Less_One()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "7999999999";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PhoneNumber_Max()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "8000000000";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PhoneNumber_Max_Plus_One()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "8000000001";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void PhoneNumber_Mid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "7500000000";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PhoneNumber_Extreme_Max()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "9000000000000";
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumber_Invalid_Data()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //set the PhoneNumber to a non integer value
            string PhoneNumber = "Hello";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
