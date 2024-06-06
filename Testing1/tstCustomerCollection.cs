using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see if it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK() 
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be  a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.isActive = true;
            TestItem.CustomerId = 27;
            TestItem.Age = 29;
            TestItem.PhoneNumber = 7897564987;
            TestItem.FirstName = "Jake";
            TestItem.LastName = "Black";
            TestItem.DateJoined = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]

        public void ThisCustomerPropertyOK() 
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.isActive = true;
            TestCustomer.CustomerId = 27;
            TestCustomer.Age = 29;
            TestCustomer.PhoneNumber = 789756487;
            TestCustomer.FirstName = "Jake";
            TestCustomer.LastName = "Black";
            TestCustomer.DateJoined = DateTime.Now;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be  a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.isActive = true;
            TestItem.CustomerId = 27;
            TestItem.Age = 29;
            TestItem.PhoneNumber = 78975647;
            TestItem.FirstName = "Jake";
            TestItem.LastName = "Black";
            TestItem.DateJoined = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]

        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 27;
            TestItem.Age = 29;
            TestItem.PhoneNumber = 789756498;
            TestItem.isActive = true;
            TestItem.FirstName = "Jake";
            TestItem.LastName = "Black";
            TestItem.DateJoined = DateTime.Now;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 27;
            TestItem.Age = 29;
            TestItem.PhoneNumber = 789756498;
            TestItem.isActive = true;
            TestItem.FirstName = "Jake";
            TestItem.LastName = "Black";
            TestItem.DateJoined = DateTime.Now;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //modify the test record
            TestItem.CustomerId = 72;
            TestItem.Age = 92;
            TestItem.PhoneNumber = 784567772;
            TestItem.isActive = false;
            TestItem.FirstName = "Oliver";
            TestItem.LastName = "White";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 27;
            TestItem.Age = 29;
            TestItem.PhoneNumber = 789756498;
            TestItem.isActive = true;
            TestItem.FirstName = "Jake";
            TestItem.LastName = "Black";
            TestItem.DateJoined = DateTime.Now;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFirstName()
        {
            //create an instance of the class containing unfiltered results 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomers.ReportByFirstName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);  
        }

        [TestMethod]
        public void ReportByLastNameNoneFound() 
        {
            //create an instance of the class we want to create
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a first name that doesn't exist
            FilteredCustomers.ReportByFirstName("nofirstnamexxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]

        public void ReportByFirstNameDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a first name that has 2 records
            FilteredCustomers.ReportByFirstName("Espanol");
            if (FilteredCustomers.Count == 2)
            {
                //check to see that the first record is 64
                if (FilteredCustomers.CustomerList[0].CustomerId !=64)
                {
                    OK = false;
                }
                //check to see that the second record is 65
                if (FilteredCustomers.CustomerList[1].CustomerId !=65)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);  
        }

    }
}
