using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderProcessingCollection
    {
        //private data member for the list
        List<clsOrderProcessing> mOrderList = new List<clsOrderProcessing>();

        //public property for the address list
        public List<clsOrderProcessing> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        public clsOrderProcessing ThisOrder { get; set; }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        //constructor for the class
        public clsOrderProcessingCollection() 
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("spoc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
                //read in the fields for the current record
                AnOrderProcessing.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrderProcessing.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrderProcessing.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrderProcessing.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);
                AnOrderProcessing.IsCancelled = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsCancelled"]);
                //add the record to the private data member
                mOrderList.Add(AnOrderProcessing);
                //point at the next record
                Index++;
            }
        }
      
    }
}