using System;
using System.Reflection;

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
        private Int32 mItemId;
        // ItemId public property
        public Int32 ItemId 
        {
            get
            {
                //this line of code sends data out of the property
                return mItemId;
            }
            set
            {
                //this line of code allows data into the property
                mItemId = value;
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

        public bool Find(int ItemId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Item Id to search for
            DB.AddParameter("@ItemId", ItemId);
            //execute the store procedure
            DB.Execute("sproc_tbStock_FilterByItemId");
            if (DB.Count == 1 )
            {
                //copy the data from the database to the private data member
                mItemId = Convert.ToInt32(DB.DataTable.Rows[0]["ItemId"]);
                mItemDescription = Convert.ToString(DB.DataTable.Rows[0]["ItemDescription"]);
                mRestockDate = Convert.ToDateTime(DB.DataTable.Rows[0]["RestockDate"]);
                mQuantityInStock = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityInStock"]);
                mItemPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ItemPrice"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }

        }

        public string Valid(string itemDescription, string restockDate, string quantityInStock, string itemPrice)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //create a temporary variable to store the data values
            Int32 ValueTemp;
            //create a temporary variable to store the date values
            Decimal PriceTemp;
            
            //if the itemDescription is blank
            if (itemDescription.Length == 0)
            {
                //record error
                Error = Error + "The Item Description may not be blank : ";
            }
            //if Item description is greater then 50 characters 
            if (itemDescription.Length > 50)
            {
                //record error
                Error = Error + "The Item Description must be less then 50 characters : ";
            }
     
            try
            {
                //copy the restockDate values to the DateTemp variable
                DateTemp = Convert.ToDateTime(restockDate);
                //check if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date connot be in the pass : ";
                }
                //check if the date is grater than today's date plus 365 days
                if (DateTemp > DateTime.Now.Date.AddDays(365))
                {
                    //record error
                    Error = Error + "The date connot grater then today plus 365 days : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not valide date : ";
            }

            try
            {
                //copy the QuantityInStock values to the ValueTemp variable
                ValueTemp = Convert.ToInt32(quantityInStock);
                //check if the value is less than 0 
                if (ValueTemp < 0)
                {
                    Error = Error + "The value connot be less the 0 : ";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The value was not valid vatue : ";
            }

            try
            {
                //copy the ItemPrice values to the PriceTemp variable
                PriceTemp = Convert.ToDecimal(itemPrice);
                //check if the value is less than 0 
                if (PriceTemp < 0.00m)
                {
                    Error = Error + "The prise connot be less the 0.00 : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The price was not valid vatue : ";
            }
            
            //return any error messages
            return Error;
        }
    }
}