using System;
using System.IO;

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
        private DateTime mOrderDate;
        //date added public property
        public DateTime OrderDate
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderDate;
            }

            set
            {
                //this line of code allows data into the property
                mOrderDate = value;
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
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
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

        public string Valid(String OrderDate, String OrderStatus, String PaymentMethod)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary varaible to store the date values
            DateTime DateTemp;
            if (OrderStatus.Length == 0)
            {
                //record the error
                Error = Error + "The OrderStatus may not be blank : ";
            }
            //if the OrderStatus is greater than 50 characters
            if (OrderStatus.Length > 50)
            {
                //record the error
                Error = Error + "The OrderStatus must be less than 50 characters : ";
            }

            if (PaymentMethod.Length == 0 )
            {
                //record the error
                Error = Error + "The PaymentMethod may not be blank : ";
            }

            if (PaymentMethod.Length > 50 )
            {
                //record the error
                Error = Error + "The PaymentMethod must be less than 50 characters : ";
            }

            

            //create an instance of the DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the OrderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(OrderDate);
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch 
            {
                //record the error
                Error = Error + "The date was not a  valid date : ";
            }

            //return any error message
            return Error;
        }
       
       

    }
}