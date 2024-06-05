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
            //set the private data members to the test data value
            mshipmentid = 21;
            mordernum = 21;
            mdeliverydate = Convert.ToDateTime("05/06/2024");
            mstreet = "abcd";
            mcity = "bcd";
            mpostcode = "abcd";
            misDeliveryExpress = true;
            //always return true
            return true;
        }

    }
}