using System;

namespace ClassLibrary
{
    public class clsShipment
    {


            //private data member for the address id property
            private Int32 mshipmentid;
            
            //shipment is public property

            public Int32 shipmentid
            {
                get
                {
                    //this line of code sends data out of the propert
                    return mshipmentid;
                }
                set
                {
                    //this line of code allowsa data into the property
                    mshipmentid = value;
                }
            }



        //private data member for the address id property
        private DateTime mdeliverydate;

        //shipment is public property

        public DateTime deliverydate
        {
            get
            {
                //this line of code sends data out of the propert
                return mdeliverydate;
            }
            set
            {
                //this line of code allowsa data into the property
                mdeliverydate = value;
            }
        }





        //private data member for the address id property
        private string mstreet;

        //shipment is public property

        public string street
        {
            get
            {
                //this line of code sends data out of the propert
                return mstreet;
            }
            set
            {
                //this line of code allowsa data into the property
                mstreet = value;
            }
        }



        //private data member for the address id property
        private string mcity;

        //shipment is public property

        public string city
        {
            get
            {
                //this line of code sends data out of the propert
                return mcity;
            }
            set
            {
                //this line of code allowsa data into the property
                mcity = value;
            }
        }





        //private data member for the address id property
        private string mpostcode;

        //shipment is public property

        public string postcode
        {
            get
            {
                //this line of code sends data out of the propert
                return mpostcode;
            }
            set
            {
                //this line of code allowsa data into the property
                mpostcode = value;
            }
        }



        //private data member for the address id property
        private Int32 mordernum;

        //shipment is public property

        public Int32 ordernum
        {
            get
            {
                //this line of code sends data out of the propert
                return mordernum;
            }
            set
            {
                //this line of code allowsa data into the property
                mordernum = value;
            }
        }



        //private data member for the address id property
        private bool misDeliveryExpress;

        //shipment is public property

        public bool isDeliveryExpress
        {
            get
            {
                //this line of code sends data out of the propert
                return misDeliveryExpress;
            }
            set
            {
                //this line of code allowsa data into the property
                misDeliveryExpress = value;
            }
        }

        public bool Find(int shipmentid)
        {
            //create an instance  of data conncetion
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the shipmentid to search for
            DB.AddParameter("@shipmentid", shipmentid);
            //execute the stored procedure
            DB.Execute("sproc_tblShipment_FilterByshipmentid");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {


                //copy the data from data base to the private data members
                mshipmentid = Convert.ToInt32(DB.DataTable.Rows[0]["shipmentid"]);
                mordernum = Convert.ToInt32(DB.DataTable.Rows[0]["ordernum"]);
                mdeliverydate = Convert.ToDateTime(DB.DataTable.Rows[0]["deliverydate"]);
                mstreet = Convert.ToString(DB.DataTable.Rows[0]["street"]);
                mcity = Convert.ToString(DB.DataTable.Rows[0]["city"]);
                mpostcode = Convert.ToString(DB.DataTable.Rows[0]["postcode"]);
                misDeliveryExpress = Convert.ToBoolean(DB.DataTable.Rows[0]["isDeliveryExpress"]);
                //always that everything worked ok
                return true;
            }
            //if no record found
            else
            {
                //false means problem 
                return false;
            }
        }

    }
}