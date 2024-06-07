using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderProcessingCollection
    {
        //private data member for the list
        List<clsOrderProcessing> mOrderList = new List<clsOrderProcessing>();

        //private data member for ThisOrder
        clsOrderProcessing mThisOrder = new clsOrderProcessing();

        //constructor for the class
        public clsOrderProcessingCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("spoc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }


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
        //public property for ThisOrder
        public clsOrderProcessing ThisOrder 
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

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
      

        public int Add()
        {
            //adds a record to the database based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@IsCancelled", mThisOrder.IsCancelled);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //update an existing record based on the valies of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);
            DB.AddParameter("@IsCancelled", mThisOrder.IsCancelled);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByPaymentMethod(string PaymentMethod)
        {
            //filters the record based on a full or partial PaymentMethod
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the payment method parameter to the database
            DB.AddParameter("@PaymentMethod", PaymentMethod);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByPaymentMethod");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //varaible to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrderProcessing>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address object
                clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
                //read in the fields from the current record
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