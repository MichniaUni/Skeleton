using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the CustomerId property
        private Int32 mCustomerId;
        // CustomerId public property
        public Int32 CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }

        //private data member for the DateJoined property
        private DateTime mDateJoined;
        // DateJoined public property
        public DateTime DateJoined
        {
            get
            {
                //this line of code sends data out of the property
                return mDateJoined;
            }
            set
            {
                //this line of code allows data into the property
                mDateJoined = value;
            }
        }

        //private data member for the isActive property
        private Boolean misActive;
        // isActive public property
        public Boolean isActive
        {
            get
            {
                //this line of code sends data out of the property
                return misActive;
            }
            set
            {
                //this line of code allows data into the property
                misActive = value;
            }
        }

        //private data member for the PhoneNumber property
        private Int64 mPhoneNumber;
        // PhoneNumber public property
        public Int64 PhoneNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mPhoneNumber;
            }
            set
            {
                //this line of code allows data into the property
                mPhoneNumber = value;
            }
        }

        //private data member for the Age property
        private long mAge;
        // Age public property
        public long Age
        {
            get
            {
                //this line of code sends data out of the property
                return mAge;
            }
            set
            {
                //this line of code allows data into the property
                mAge = value;
            }
        }

        //private data member for the LastName property
        private string mLastName;
        // LastName public property
        public string LastName
        {
            get
            {
                //this line of code sends data out of the property
                return mLastName;
            }
            set
            {
                //this line of code allows data into the property
                mLastName = value;
            }
        }

        //private data member for the FirsName property
        private string mFirstName;
        // FirstName public property
        public string FirstName
        {
            get
            {
                //this line of code sends data out of the property
                return mFirstName;
            }
            set
            {
                //this line of code allows data into the property
                mFirstName = value;
            }
        }

        /********************** FIND METHOD *********************/
        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CustomerId to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the store procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNumber"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mAge = Convert.ToInt32(DB.DataTable.Rows[0]["Age"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                misActive = Convert.ToBoolean(DB.DataTable.Rows[0]["isActive"]);
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

        public string Valid(string firstName, string lastName, string age, string phoneNumber, string dateJoined)
        {
            //create a string variable to store the error
            String Error = "";
            //if the FirstName is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The first name may not be blank : ";
            }
            //if the FirstName is greater than 50 characters
            if (firstName.Length > 50)
            {
                //record the error
                Error = Error + "The first name must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }



    }
}