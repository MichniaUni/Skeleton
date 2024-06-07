using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace ClassLibrary
{
    
    public class clsSupplierCollection
    {

        //private data member for the list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        //private member data for thius supplier
        clsSupplier mThisSupplier= new clsSupplier();
        public List<clsSupplier> SupplierList
        {
            get
            {
                //return the privetw data
                return mSupplierList;
            }
            set
            {
                //set the private data
                mSupplierList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return SupplierList.Count;
            }
            set
            {
                //
            }
        }
        public clsSupplier ThisSupplier
        {
            get
            {
                //return the privete data
                return mThisSupplier;
            }
            set
            {//set the private data

                mThisSupplier = value;
            }
        }

        public clsSupplierCollection()
        { 

            
            //variable for the index 
            Int32 Index = 0;
            //variable to store the recpord count
            Int32 RecordCount = 0;
            //object for the data connectiom
            clsDataConnection DB = new clsDataConnection();
            //excute the stored procdure
            DB.Execute("sproc_tblSupplier_SelectALL");

            //populate the array list with the data table
            PopulateArray(DB);

            /*//get the count of record
            RecordCount = DB.Count;*/

            //while there are records to process
            while (Index < RecordCount)
            {//create a blank supplier
                clsSupplier AnSupplier = new clsSupplier();
                //read the fields for the current record
                AnSupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                AnSupplier.ProductionDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ProductionDate"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                AnSupplier.Shipmentstatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["Shipmentstatus"]);
                AnSupplier.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnSupplier.ExpiryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ExpiryDate"]);
                AnSupplier.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                //add the record to the privete data member
                mSupplierList.Add(AnSupplier);
                //point at the next record
                Index++;   

            
        }

        }

        public int Add()
        {
           //add a record to the database on the values of mThisSupplier
           //connect to the database
           clsDataConnection DB= new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ProductionDate", mThisSupplier.ProductionDate);
            DB.AddParameter("@ExpiryDate", mThisSupplier.ExpiryDate);
            DB.AddParameter("@Quantity", mThisSupplier.Quantity);
            DB.AddParameter("@Price", mThisSupplier.Price);
            DB.AddParameter("@Shipmentstatus", mThisSupplier.Shipmentstatus);
            //excute the query returning the primary key value
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            //update an existing record based on the value4 of thissupplier
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ProductionDate", mThisSupplier.ProductionDate);
            DB.AddParameter("@ExpiryDate", mThisSupplier.ExpiryDate);
            DB.AddParameter("@Quantity", mThisSupplier.Quantity);
            DB.AddParameter("@Price", mThisSupplier.Price);
            DB.AddParameter("@Shipmentstatus", mThisSupplier.Shipmentstatus);
            //excute the stored procedure
            DB.Execute("sproc_tblSupplier_Update");

        }

        public void Delete()
        {
            //deletes the record pointed by this supplier
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            //excute the stored procedure
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportBySupplierName(string SupplierName)
        {
            //filters record based on fill or parlial suppliername
            //conect to the database
            clsDataConnection DB= new clsDataConnection();
            //send the suppliername parameter to database
            DB.AddParameter("@SupplierName", SupplierName);
            //excute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        public void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter db
            //variable fir the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of the record
             RecordCount = DB.Count;
            //clear the private array list
            mSupplierList = new List<clsSupplier>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank supplier
                clsSupplier AnSupplier = new clsSupplier();
                //read the fields for the current record
                AnSupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                AnSupplier.ProductionDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ProductionDate"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                AnSupplier.Shipmentstatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["Shipmentstatus"]);
                AnSupplier.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnSupplier.ExpiryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ExpiryDate"]);
                AnSupplier.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                //add the record to the privete data member
                mSupplierList.Add(AnSupplier);
                //point at the next record
                Index++;
            }
            
        }

    }
}