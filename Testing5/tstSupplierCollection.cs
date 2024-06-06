﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //test to see that it exists
            Assert.IsNotNull(AllSupplier);
        }
        [TestMethod]
        public void SupplierListOK()
        {
            //create an instance of class we want
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            //the data need to be a list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();
            //Add an Item to the List
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.Shipmentstatus= true;
            
            TestItem.SupplierName = "Test";
            TestItem.Quantity = 10;
            TestItem.ProductionDate= DateTime.Now;
            TestItem.ExpiryDate= DateTime.Now;
            TestItem.Price = 10.5m;
            //add the iteam to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSuppliers.SupplierList= TestList;
            //test to see tht two values are same
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }
       
        [TestMethod]
        public void ThisSupplierPropertyOk()
        {
            //create an instance of class we want
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            clsSupplier TestSupplier= new clsSupplier();
            
            //set properties  of test object
            TestSupplier.Shipmentstatus = true;

            TestSupplier.SupplierName = "Test";
            TestSupplier.Quantity = 10;
            TestSupplier.ProductionDate = DateTime.Now;
            TestSupplier.ExpiryDate = DateTime.Now;
            TestSupplier.Price = 10.5m;
            //assign the data to the property
            AllSuppliers.ThisSupplier= TestSupplier;
            
            //test to see tht two values are same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of class we want
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            //the data need to be a list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();
            //Add an Item to the List
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.Shipmentstatus = true;

            TestItem.SupplierName = "Test";
            TestItem.Quantity = 10;
            TestItem.ProductionDate = DateTime.Now;
            TestItem.ExpiryDate = DateTime.Now;
            TestItem.Price = 10.5m;
            //add the iteam to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSuppliers.SupplierList = TestList;
            //test to see tht two values are same
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }
        //*****************Add*************//
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of class we want
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Shipmentstatus = true;
            TestItem.SupplierID = 3;
            TestItem.SupplierName = "Test";
            TestItem.Quantity = 10;
            TestItem.ProductionDate = DateTime.Now;
            TestItem.ExpiryDate = DateTime.Now;
            TestItem.Price = 10.5m;
            //set This address to test data
            AllSuppliers.ThisSupplier = TestItem;
            //add record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data
            TestItem.SupplierID= PrimaryKey;
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
           
            //test to see tht two values are same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of class we want
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();

            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Shipmentstatus = true;

            TestItem.SupplierName = "Test";
            TestItem.Quantity = 10;
            TestItem.ProductionDate = DateTime.Now;
            TestItem.ExpiryDate = DateTime.Now;
            TestItem.Price = 10.5m;
            //set This address to test data
            AllSuppliers.ThisSupplier = TestItem;
            //add record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data
            TestItem.SupplierID = PrimaryKey;
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //modify the test record
            TestItem.Shipmentstatus = false;

            TestItem.SupplierName = "Another Name";
            TestItem.Quantity = 5;
            TestItem.ProductionDate = DateTime.Now;
            TestItem.ExpiryDate = DateTime.Now;
            TestItem.Price = 15.5m;
            //set the record based on new test data
            AllSuppliers.ThisSupplier = TestItem;
            //update the record
            AllSuppliers.Update();
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);

            //test to see tht two values are same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);

        }

    }
}
