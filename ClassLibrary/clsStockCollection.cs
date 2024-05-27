using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the records count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execude the store procedure
            DB.Execute("sproc_tbStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while they are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStock AnStock = new clsStock();
                //read it from fields for the current record
                AnStock.ItemId = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemId"]);
                AnStock.ItemDescription = Convert.ToString(DB.DataTable.Rows[Index]["ItemDescription"]);
                AnStock.RestockDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["RestockDate"]);
                AnStock.QuantityInStock = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityInStock"]);
                AnStock.ItemPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["ItemPrice"]);
                AnStock.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                //add the record to the private data member
                mItemList.Add(AnStock);
                //pointat the next record
                Index++;
            }

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