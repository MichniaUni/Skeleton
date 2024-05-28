using System;

namespace ClassLibrary
{
    public class clsOrderProcessing
    {

        //private data member for the Order Id property
        private Int32 mOrderId;
        
        //OrderId public property
        public Int32 OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }

        //private data member for the is cancelled property
        private Boolean mIsCancelled;
        //is cancelled public property

        public bool IsCancelled
        { get
            {
                //this line of code sends data out of the property
                return mIsCancelled;
            }
                
           set
            {
                //this line of code allows data into the property
                mIsCancelled = value;
            }
        }

        //private data member for the date added property
        private DateTime mDateAdded;
        //date added public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }

            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }

        //private data member for the order status property
        private String mOrderStatus;
        //order status public property
        public string OrderStatus 
        {
            get
            {
                // this line of code sends data out of the property
                return mOrderStatus;
            }
            set
            {
                //this line of code allows data into the property
                mOrderStatus = value;
            }
        }

        //private data member for the payment status property
        private string mPaymentMethod;

        //payment method public proeprty
        public string PaymentMethod
        { 
            get
            {
                //this line of code sends data out of the property
                return mPaymentMethod;
            }
            set
            {
                //this line of code allows data into the propeerty
                mPaymentMethod = value;
            }
        }

        /******FIND METHOD******/
        public bool Find(int OrderId)
        {
            //create the instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for 
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one round is found ( there should be either one or zero)
            if (DB.Count ==1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                mIsCancelled = Convert.ToBoolean(DB.DataTable.Rows[0]["IsCancelled"]);
                // return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
           
        }
  
    }
}