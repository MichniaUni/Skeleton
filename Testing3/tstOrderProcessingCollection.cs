using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Testing3
{
    [TestClass]
    public class tstOrderProcessingCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsOrderProcessingCollection AllOrderProcessing = new clsOrderProcessingCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrderProcessing);

        }
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessingCollection AllOrderProcessing = new clsOrderProcessingCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrderProcessing> TestList = new List<clsOrderProcessing>();
            //add an item to the list
            //create the item of the test data
            clsOrderProcessing TestItem = new clsOrderProcessing();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderStatus = "pending";
            TestItem.PaymentMethod = "cash";
            TestItem.IsCancelled = true;
            //add the item to the TestList
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrderProcessing.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderProcessing.OrderList, TestList);
        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessingCollection AllOrderProcessing = new clsOrderProcessingCollection();
            //create some test data to assign to the property
            clsOrderProcessing TestOrderProcessing = new clsOrderProcessing();
            //set the properties of the test object
            TestOrderProcessing.OrderId = 1;
            TestOrderProcessing.OrderDate = DateTime.Now;
            TestOrderProcessing.OrderStatus = "pending";
            TestOrderProcessing.PaymentMethod = "cash";
            TestOrderProcessing.IsCancelled = true;
            //assign the data to the property
            AllOrderProcessing.ThisOrder = TestOrderProcessing;
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessingCollection AllOrderProcessing = new clsOrderProcessingCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsOrderProcessing> TestList = new List<clsOrderProcessing>();
            //add an item to the list
            //create the item of TestData
            clsOrderProcessing TestItem = new clsOrderProcessing();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderStatus = "pending";
            TestItem.PaymentMethod = "cash";
            TestItem.IsCancelled = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrderProcessing.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderProcessing.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want  to create 
            clsOrderProcessingCollection AllOrderProcessing = new clsOrderProcessingCollection();
            //create the item of test data
            clsOrderProcessing TestItem = new clsOrderProcessing();
            //varaible to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderStatus = "pending";
            TestItem.PaymentMethod = "cash";
            TestItem.IsCancelled = true;
            //set ThisOrder to the test data
            AllOrderProcessing.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrderProcessing.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //Find the record
            AllOrderProcessing.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderProcessing.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessingCollection AllOrderProcessing = new clsOrderProcessingCollection();
            //create the item of the test data
            clsOrderProcessing TestItem = new clsOrderProcessing();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderStatus = "confirmed";
            TestItem.PaymentMethod = "card";
            TestItem.IsCancelled = true;
            //set ThisOrder to the test data
            AllOrderProcessing.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrderProcessing.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //Modify the test record
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderStatus = "pending";
            TestItem.PaymentMethod = "cash on delivery";
            TestItem.IsCancelled = false;
            //set the record based on the new test data
            AllOrderProcessing.ThisOrder = TestItem;
            //update the record
            AllOrderProcessing.Update();
            //find the record 
            AllOrderProcessing.ThisOrder.Find(PrimaryKey);
            //test to see if ThisOrder matches the test data
            Assert.AreEqual(AllOrderProcessing.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessingCollection AllOrderProcessing = new clsOrderProcessingCollection();
            //create the item of the test data
            clsOrderProcessing TestItem = new clsOrderProcessing();
            //varaible to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderStatus = "Pending";
            TestItem.PaymentMethod = "Card";
            TestItem.IsCancelled = true;
            //set ThisOrder to the test data
            AllOrderProcessing.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrderProcessing.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrderProcessing.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrderProcessing.Delete();
            //now find the record
            Boolean Found = AllOrderProcessing.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByPaymentMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderProcessingCollection AllOrderProcessing = new clsOrderProcessingCollection();
            //create an instance of the filtered data
            clsOrderProcessingCollection FilteredOrderProcessing = new clsOrderProcessingCollection();
            //apply a blank string (should return all records)
            FilteredOrderProcessing.ReportByPaymentMethod("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderProcessing.Count, FilteredOrderProcessing.Count);

        }
        [TestMethod]
        public void ReportByPaymentMethodNoneFound()
        {
            //create an instance of the class we want to create
            clsOrderProcessingCollection FilteredOrderProcessing = new clsOrderProcessingCollection();
            //apply a payment method that doesnt exist
            FilteredOrderProcessing.ReportByPaymentMethod("zzzz zz zz");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrderProcessing.Count);
        }
        [TestMethod]
        public void ReportByPaymentMethodTestDataFound()
        {
            //create an instance of the filtered data 
            clsOrderProcessingCollection FilteredOrderProcessing = new clsOrderProcessingCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a payment method that doesnt exist
            FilteredOrderProcessing.ReportByPaymentMethod("cashbypost");
            //check that the two correct numbers of records are found
            if (FilteredOrderProcessing.Count == 2)
            {
                //check to see that the first record is 25
                if (FilteredOrderProcessing.OrderList[0].OrderId != 69)
                {
                    OK = false;
                }
                //check to see that the first record is 26
                if (FilteredOrderProcessing.OrderList[1].OrderId != 70)
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
