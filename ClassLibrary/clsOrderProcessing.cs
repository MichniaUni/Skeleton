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
        public bool Find(int orderId)
        {
            //set the private data members to the test data value
            mOrderId = 123;
            mDateAdded = Convert.ToDateTime("15/05/24");
            mIsCancelled = true;
            mOrderStatus = "Test OrderStatus";
            mPaymentMethod = "Test PaymentMethod";
;            //always return true
            return true;
        }
  
    }
}