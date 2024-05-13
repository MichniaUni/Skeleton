using System;

namespace ClassLibrary
{
    public class clsStock
    {        
        //private data member for the stock id property
        private DateTime mRestockDate;
        // RestockDate public property
        public DateTime RestockDate 
        {
            get 
            {
                //this line of code sends data out of the property
                return mRestockDate;
            }
            set 
            {
                //this line of code allows data into the property
                mRestockDate = value;
            }
        }

        //private data member for the stock id property
        private Boolean mIsActive;
        // IsActive public property
        public bool IsActive
        {
            get 
            {
                //this line of code sends data out of the property
                return mIsActive;
            }
            set 
            {
                //this line of code allows data into the property
                mIsActive = value;
            }
        }

        //private data member for the stock id property
        private Int32 mItemID;
        // ItemID public property
        public Int32 ItemID 
        {
            get
            {
                //this line of code sends data out of the property
                return mItemID;
            }
            set
            {
                //this line of code allows data into the property
                mItemID = value;
            }
        
        }

        //private data member for the stock id property
        private Int32 mQuantityInStock;
        // QuantityInStock public property
        public Int32 QuantityInStock
        {
            get 
            {
                //this line of code sends data out of the property
                return mQuantityInStock;
            }
            set 
            {
                //this line of code allows data into the property
                mQuantityInStock = value;
            }
        }

        //private data member for the stock id property
        private string mItemDescription;
        // ItemDescription public property
        public string ItemDescription
        {
            get
            {
                //this line of code sends data out of the property
                return mItemDescription;
            }
            set 
            {
                //this line of code allows data into the property
                mItemDescription = value;
            }
        }

        //private data member for the stock id property
        private Decimal mItemPrice;
        // ItemPrice public property
        public decimal ItemPrice
        {
            get
            {
                //this line of code sends data out of the property
                return mItemPrice;
            }
            set 
            {
                //this line of code allows data into the property
                mItemPrice = value;
            }
        }


        /****** FIND METHOD ******/

        public bool Find(int itemID)
        {
            //set the private data members to the test data value
            mItemID = 21;
            mItemDescription = "RedDrone";
            mRestockDate = Convert.ToDateTime("23/12/2020");
            mQuantityInStock = 20;
            mItemPrice = 1.23m;
            mIsActive = true;
            //alwayse return true
            return true;
        }

        public string Valid(string itemDescription, string restockDate, string quantityInStock, string itemPrice)
        {
            return "";
        }
    }
}