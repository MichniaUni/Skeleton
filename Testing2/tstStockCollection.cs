using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class Stock
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that is exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void ItemListOK()
        {
            //create an instance of the class Stock
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //the data need to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //Add an Item to the List
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ItemDescription = "RedDrones";
            TestItem.RestockDate = DateTime.Now;
            TestItem.QuantityInStock = 10;
            TestItem.ItemPrice = 12.25m;
            TestItem.IsActive = true;
            //add the tiem to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.ItemList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ItemList, TestList);
        }

        

        [TestMethod]
        public void ThisItemPropertyOK()
        {
            //create an instance of the class Stock
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();
            //set the properties of the test object
            TestItem.ItemDescription = "RedDrones";
            TestItem.RestockDate = DateTime.Now;
            TestItem.QuantityInStock = 10;
            TestItem.ItemPrice = 12.25m;
            TestItem.IsActive = true;
            //assign the data to the property
            AllStock.ThisItem = TestItem;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisItem, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class Stock
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //the data need to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an Item to the List
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ItemDescription = "RedDrones";
            TestItem.RestockDate = DateTime.Now;
            TestItem.QuantityInStock = 10;
            TestItem.ItemPrice = 12.25m;
            TestItem.IsActive = true;
            //add the tiem to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.ItemList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        
    }
}
