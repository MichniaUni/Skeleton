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

            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblShipment_SelectAll");

            //populate the array lisyt with the data table
            PopulateArray(DB);

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



        public void Update()
        {
            //update an existing record based on Thisshipment
            //connect to the database

            clsDataConnection DB = new clsDataConnection();
            //set the paramaters for the stored procedure
            DB.AddParameter("@shipmentid", mThisShipment.shipmentid);
            DB.AddParameter("@street", mThisShipment.street);
            DB.AddParameter("@city", mThisShipment.city);
            DB.AddParameter("@postcode", mThisShipment.postcode);
            DB.AddParameter("@deliverydate", mThisShipment.deliverydate);
            DB.AddParameter("@ordernum", mThisShipment.ordernum);
            DB.AddParameter("@isDeliveryExpress", mThisShipment.isDeliveryExpress);

            //execute the stored procedure
            DB.Execute("sproc_tblShipment_Update");
        }



        public void Delete()
        {
            //Delete an existing record based on Thisshipment
            //connect to the database

            clsDataConnection DB = new clsDataConnection();
            //set the paramaters for the stored procedure
            DB.AddParameter("@shipmentid", mThisShipment.shipmentid);


            //execute the stored procedure
            DB.Execute("sproc_tblShipment_Delete");
        }


        public void ReportByPostCode(string postcode)
        {
            //filters the record
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send postcode parameter to the database
            DB.AddParameter("@postcode", postcode);
            //execute the sproc
            DB.Execute("sproc_tblShipment_FilterByPostCode");

            //populate the array list with the datatable
            PopulateArray(DB);

        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the arraqay list 

            //varibale for the index
            Int32 Index = 0;
            //vareiable to stroe teh record count
            Int32 RecordCount;
            //get th e counts of record
            RecordCount = DB.Count;
            //clear the private array list
            mShipmentList = new List<clsShipment>();
            //while there are records to preocess
            while (Index < RecordCount)
            {
                clsShipment AnShipment = new clsShipment();
                AnShipment.isDeliveryExpress = Convert.ToBoolean(DB.DataTable.Rows[Index]["isDeliveryExpress"]);
                AnShipment.street = Convert.ToString(DB.DataTable.Rows[Index]["street"]);
                AnShipment.city = Convert.ToString(DB.DataTable.Rows[Index]["city"]);
                AnShipment.postcode = Convert.ToString(DB.DataTable.Rows[Index]["postcode"]);
                AnShipment.shipmentid = Convert.ToInt32(DB.DataTable.Rows[Index]["shipmentid"]);
                AnShipment.ordernum = Convert.ToInt32(DB.DataTable.Rows[Index]["ordernum"]);
                AnShipment.deliverydate = Convert.ToDateTime(DB.DataTable.Rows[Index]["deliverydate"]);
                //add the record to the private data ,members
                mShipmentList.Add(AnShipment);
                //point at the next record
                Index++;
            }
        }
    }
    
}