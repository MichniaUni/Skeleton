using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsShipmentCollection
    {

        //private data member for the list
        List<clsShipment> mShipmentList = new List<clsShipment>();

        //preivate data member for this Shipment
        clsShipment mThisShipment = new clsShipment();  
        public clsShipmentCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store record count
            Int32 RecordCount = 0;
            //data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblShipment_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                //create a blank shipment
                clsShipment AnShipment = new clsShipment(); 
                AnShipment.isDeliveryExpress = Convert.ToBoolean(DB.DataTable.Rows[Index]["isDeliveryExpress"]);
                AnShipment.street = Convert.ToString(DB.DataTable.Rows[Index]["street"]);
                AnShipment.city = Convert.ToString(DB.DataTable.Rows[Index]["city"]);
                AnShipment.postcode = Convert.ToString(DB.DataTable.Rows[Index]["postcode"]);
                AnShipment.shipmentid = Convert.ToInt32(DB.DataTable.Rows[Index]["shipmentid"]);
                AnShipment.ordernum = Convert.ToInt32(DB.DataTable.Rows[Index]["ordernum"]);
                AnShipment.deliverydate = Convert.ToDateTime(DB.DataTable.Rows[Index]["deliverydate"]);
                mShipmentList.Add(AnShipment);
                //point for next record
                Index++;


            }
            
          
        }


       

        



        public List<clsShipment> ShipmentList
        {
            get
            {
                //return the private data
                return mShipmentList;
            }
            set
            {
                mShipmentList = value;
            }
        }

             
        public int Count
        {
            get
            {
                return mShipmentList.Count;
            }
            set
            {
                //laterrr
            }
        }
        public clsShipment ThisShipment
        {
            get
            {
                //erturn private data
                return mThisShipment;
            }
            set
            {
                //set private data
                mThisShipment = value;  
            }
        }

        public int Add()
        {
            //adds a record to database based on the value of m thisshipment
            // connect to the database
           clsDataConnection DB = new clsDataConnection();
            //set the paramaters for the stored procedure
            DB.AddParameter("@street", mThisShipment.street);
            DB.AddParameter("@city", mThisShipment.city);
            DB.AddParameter("@postcode", mThisShipment.postcode);
            DB.AddParameter("@deliverydate", mThisShipment.deliverydate);
            DB.AddParameter("@ordernum", mThisShipment.ordernum);
            DB.AddParameter("@isDeliveryExpress", mThisShipment.isDeliveryExpress);

            //execute the query returning the primary key valuer
            return DB.Execute("sproc_tblAddress_Insert");

        }
    }
}