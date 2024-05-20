using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        public clsStockCollection()
        {
            //create the items of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.IsActive = true;
            TestItem.ItemDescription = "RedDrones";
            TestItem.RestockDate = DateTime.Now;
            TestItem.QuantityInStock = 1;
            TestItem.ItemPrice = 1.23m;
            //add the test item to the test list
            mItemList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsStock();
            //set its properties
            TestItem.IsActive = true;
            TestItem.ItemDescription = "BlueDrones";
            TestItem.RestockDate = DateTime.Now;
            TestItem.QuantityInStock = 2;
            TestItem.ItemPrice = 5.23m;
            //add the test item to the test list
            mItemList.Add(TestItem);

        }
        
        
        //private data member for the list
        List<clsStock> mItemList = new List<clsStock>();

        public List<clsStock> ItemList
        {
            get
            {
                //return the private data
                return mItemList;
            }
            set
            {
                //set the private data
                mItemList = value;
            }
        }
        public int Count 
        {
            get
            {
                //return the count of the list
                return mItemList.Count;
            }
            set
            {

            }
        }

        public clsStock ThisItem { get; set; }
    }
}