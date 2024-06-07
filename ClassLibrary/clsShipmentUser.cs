using System;

namespace ClassLibrary
{
    public class clsShipmentUser
    {
        //private data member for the user id
        private Int32 mUserId;
        //private data member for the user name
        private string mUserName;
        //private data member for the password 
        private string mPassword;
        //private data member for the department 
        private string mDepartment;



        public int UserId
        {
            get
            {
                //return the private data
                return mUserId;
            }
            set
            {
                //set the private data
                mUserId = value;
            }
        }

        public string UserName
        {
            get
            {
                //return the private data
                return mUserName;
            }
            set
            {
                //set the private data
                mUserName = value;
            }
        }

        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the private data
                mPassword = value;
            }
        }

        public string Department
        {
            get
            {
                //return the private data
                return mDepartment;
            }
            set
            {
                //set the private data
                mDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the user username and password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //execute the store procedure
            DB.Execute("sproc_tblUser_FindUserNameAndPassword");
            //if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                return false;
            }
        }


    }
}