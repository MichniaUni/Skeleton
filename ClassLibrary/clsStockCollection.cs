using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private member data for thisStock
        clsStock mThisItem = new clsStock();

        public clsStockCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tbStock_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
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

        //public property for ThisItem
        public clsStock ThisItem
        {
            get 
            {
                //return the private data
                return mThisItem;
            }
            set 
            {
                //set the private data
                mThisItem = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisitem
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ItemDescription", mThisItem.ItemDescription);
            DB.AddParameter("@RestockDate", mThisItem.RestockDate);
            DB.AddParameter("@QuantityInStock", mThisItem.QuantityInStock);
            DB.AddParameter("@ItemPrice", mThisItem.ItemPrice);
            DB.AddParameter("@IsActive", mThisItem.IsActive);
            //execute the query returning the primary key values
            return DB.Execute("sproc_tbStock_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisItem
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ItemId", mThisItem.ItemId);
            DB.AddParameter("@ItemDescription", mThisItem.ItemDescription);
            DB.AddParameter("@RestockDate", mThisItem.RestockDate);
            DB.AddParameter("@QuantityInStock", mThisItem.QuantityInStock);
            DB.AddParameter("@ItemPrice", mThisItem.ItemPrice);
            DB.AddParameter("@IsActive", mThisItem.IsActive);
            //execute the store procedure
            DB.Execute("sproc_tbStock_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisItem
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the store procedure
            DB.AddParameter("@ItemId", mThisItem.ItemId);
            //execute the store procedure
            DB.Execute("sproc_tbStock_Delete");
        }

        public void ReportByItemDescription(string ItemDescription)
        {
            //filters the records based on a full ar partial description
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the itemDescription parameter to the database
            DB.AddParameter("@ItemDescription", ItemDescription);
            //execute the stored procedure
            DB.Execute("sproc_tbStock_FilterByItemDescription");
            //populate the array list with the data table
            PopulateArray(DB);

        }

        
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //cleare the private array list
            mItemList = new List<clsStock>();
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank address object
                clsStock AnStock = new clsStock();
                //read in the fields from the current records
                AnStock.ItemId = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemId"]);
                AnStock.ItemDescription = Convert.ToString(DB.DataTable.Rows[Index]["ItemDescription"]);
                AnStock.RestockDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["RestockDate"]);
                AnStock.QuantityInStock = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityInStock"]);
                AnStock.ItemPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["ItemPrice"]);
                AnStock.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                //add the record to the private data member
                mItemList.Add(AnStock);
                //point at the next record
                Index++;
            }

        }
        
    }
}