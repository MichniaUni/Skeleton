using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsShipmentCollection
    {
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


       

        //private data member for the list
        List<clsShipment> mShipmentList = new List<clsShipment>();



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
        public clsShipment ThisShipment { get; set; }
    }
}