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

        public string Valid(string firstName, string lastName, string age, string phoneNumber, string dateJoined) //Note: use 'firstName', NOT 'FirstName' 
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //create a temporary variable to store the data values
            Int32 AgeTemp;
            //create a temporary variable to store the data values
            Int64 PhoneTemp;
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
            //if the LastName is blank
            if (lastName.Length == 0)
            {
                //record the error
                Error = Error + "The last name may not be blank : ";
            }
            //if the LastName is greater than 50 characters
            if (lastName.Length > 50)
            {
                //record the error
                Error = Error + "The last name must be less than 50 characters : ";
            }
            //create an instance of DateTime to compare with DateTemp in the if statement
            DateTime DateCompare = DateTime.Now.Date;

            try
            {
                //copy the dateJoined value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateJoined);

                if (DateTemp < DateCompare) //compare dateJoined with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's daye
                if (DateTemp > DateCompare)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            try
            {
                //copy the Age values to the AgeTemp variable
                AgeTemp = Convert.ToInt32(age);
                //check if the value is less than 1 - this covers Age_Extreme_Min, Age_Min_Less_One and Age_Min
                if (AgeTemp < 1)
                {
                    Error = Error + "The age connot be less than 1 : ";
                }
                if (AgeTemp > 150) {
                    Error = Error + "The age cannot be greater than 150 : ";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The age was not valid : ";
            }

            try
            {
                //copy the PhoneNumber values to the PhoneTemp variable
                PhoneTemp = Convert.ToInt64(phoneNumber);
                //check if the value is less than 7000000000 - this covers PhoneNumber_Extreme_Min and PhoneNumber_Min_Less_One
                if (PhoneTemp < 7000000000)
                {
                    Error = Error + "The phone number connot be less than 7000000000 (you have not entered all the digits of your phone number) : ";
                }
                if (PhoneTemp > 8000000000)
                {
                    Error = Error + "The phone number cannot be greater than 8000000000 (you have entered an extra digit other than your phone number) : ";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The phone number was not valid : ";
            }


            //return any error messages
            return Error;
        }
    }
}
