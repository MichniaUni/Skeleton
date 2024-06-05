using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
       

        //private data member for Shipmentstatus property
        private Boolean mShipmentstatus;
        //Shipmentstatus public property

        public bool Shipmentstatus

        {
            get
            {
                //this code sends data out of property
                return mShipmentstatus;
            }
            set
            {
                //this line allows data into property
                mShipmentstatus = value;
            }
        }

        //private data member for the Production Date property
        private DateTime mProductionDate;
        //ProductionDate public property

        public DateTime ProductionDate
        {
            get
            { //this line code sends data out of the property
                return mProductionDate;
            }


            set
            {
                //this code allows data into property
                mProductionDate = value;
            }
        }

        //private data member for the SupplierID Property
        private Int32 mSupplierID;
        //SupplierID public property

        public Int32 SupplierID
        {
            get
            { // this line of code sends data out of the property

                return mSupplierID;
            }

            set
            {
                //this line allows data into the property
                mSupplierID = value;
            }
        }


        //private data member for the Supplier name property
        private string mSupplierName;
        //supplier name public property
        public string SupplierName
        {
            get
            {
                //this code sends data out of the property
                return mSupplierName;
            }

            set
            {
                //this code allows data into the property
                mSupplierName = value;
            }
        }

        //private data member for Quantity Proverty
        private Int32 mQuantity;
        //Quantity public property
        public int Quantity
        {
            get
            {
                //this line sends data out of the property
                return mQuantity;
            }
            set
            {

                // this code allows data into the property
                mQuantity = value;
            }
        }
        //private data member for Price Poperty
        private Decimal mPrice;

        //Price oublic poperty
        public decimal Price {
        get
            { // this code allows data into the property
                return mPrice;
            }
            set
            {// this code allows data into the property
                mPrice = value;
            }
        }

        // private data member for Expiry date property
        private DateTime mExpiryDate;
        //ExpiryDate public property
        public DateTime ExpiryDate
        {
            get
            {
                //THIS LINES SENDS data out of property
                return mExpiryDate;

            }
            set
            {
                //this code allows data into the pperty
                mExpiryDate = value;
            }
        }

        public bool Find(int SupplierID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //addparameter for the Supplier ID to search for
            DB.AddParameter("@SupplierID", SupplierID);
            //excute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mProductionDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ProductionDate"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mShipmentstatus = Convert.ToBoolean(DB.DataTable.Rows[0]["Shipmentstatus"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mExpiryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ExpiryDate"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                //return that everything worked on
                return true;
            }
            //if no recrds found
            else
            {
                //return false indicating there is problem
                return false;
            }
        }

        public string Valid(string supplierName, string productionDate, string expiryDate, string quantity, string price)
        {
            // create a string variable to store error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //create a temporary variable to store the data values
            Int32 ValueTemp;
            //create a temporary variable to store the date values
            Decimal PriceTemp;

            //is suppliuer name blank
            if (supplierName.Length == 0)
            {
                //record error
                Error = Error + "The Supplier Name cannot be blank:";

            }
            //if supplier name is too long
            if(supplierName.Length >50)
            {
                //record error
                Error = Error + "The Supplier Name must be less than 50 characters:";
            }

            
            try
            {

                //copy the ProductionDate value to DateTemp variable
                DateTemp = Convert.ToDateTime(productionDate);
                //check to see if the date is less than todays date

                if (DateTemp < DateTime.Now.Date) //compare Productiondate with date

                {//record the error
                    Error = Error + "The production date cannot be in the past;";
                }
                // check to see if the date is greater than today's date
                if (DateTemp >DateTime.Now.Date)
                {
                    // record error
                    Error = Error + "The production date cannot be in the future:";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "The date was not a valid date;";
            }

            
            try
            {
                //copy the expiry date value to the date temp variable
                DateTemp = Convert.ToDateTime(expiryDate);
                // check to see if the date is less thane today's date
                if (DateTemp <DateTime.Now.Date)
                {
                    Error = Error + "The expiry date cannot be in the past:";
                }
                // check to see if the date is greater than doday's date
                if (DateTemp > DateTime.Now.Date.AddYears(2))
                {
                    //record the error
                    Error = Error + "The expiry date cannot be more than 2 years:";
                }
            }
            catch
            {
                //record the error 
                Error = Error + " The date was not a valid date:";
            }


            try
            {
                //copy quantity value to the value to valuetemp variable
                ValueTemp = Convert.ToInt32(quantity);
                //check if the value is less than 0
                if (ValueTemp < 0)
                {
                    //record the error
                    Error = Error + "The quantity value cannot be les than 0:";

                }
            }
            catch
            {
                //record the erroe
                Error = Error + "The value was not a valid quantity value:";
            }
            try
            {
                //copy the price values to the pricetemp variable
                PriceTemp = Convert.ToDecimal(price);
                // check if the value is less than zero
                if (PriceTemp < 0.00m)
                {
                    //record the error
                    Error = Error + "The value of price cannot be leaa than zero:";

                }
            }
            catch
            {
                //record the error
                Error = Error + "The price is not a valid value for price";
            }

            //return any error message
            return Error;
        }
    }
}