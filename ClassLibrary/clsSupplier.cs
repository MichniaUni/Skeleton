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

        public DateTime ProductionDate {
            get
            { //this line code sends data out of the property
                return mProductionDate; }


            set
            {
                //this code allows data into property
                mProductionDate = value; }
                }

        //private data member for the SupplierID Property
        private Int32 mSupplierID;
        //SupplierID public property

        public Int32  SupplierID {
            get
            { // this line of code sends data out of the property

                return mSupplierID; }

                set
            { 
                //this line allows data into the property
                mSupplierID = value; }
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
        public decimal Price { get; set; }

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

        public bool Find(int supplierID)
        {
            //set the private data members to the test data value
            mSupplierID = 3;
            mProductionDate = Convert.ToDateTime("06/12/2002");
            mSupplierName = "Test SupplierName";
            mShipmentstatus=true;
            mQuantity = 10;
            mExpiryDate = Convert.ToDateTime("06/12/2004");
            //always return true
            return true;

        }
    }
}