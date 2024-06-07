using System;

namespace ClassLibrary
{
    public class clsSupplierUser
    {
        //private data member for the user id property
        private Int32 mUserId;
        //private data member for the username property
        private string mUserName;
        //private data member for the password property
        private string mPassword;
        //private data member for the department property
        private string mDepartment;


        public int UserId { 
        get { return mUserId; } set {  mUserId = value; }
        }
        public string UserName { 
        get { return mUserName; } set { mUserName = value; }
        }
        public string Password { 
        get { return mPassword; } set { mPassword = value; }
        }
        public string Department { 
        get { return mDepartment; } set { mDepartment = value; }
        }

        public bool FindUser(string UserName, string Password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the username and password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //excute the stored procdure
            DB.Execute("sproc_tblUser_FindUserNameAndPassword");
            //if one record is found (there should be either one or none)
            if (DB.Count== 1 )
            {
                //copy the data from the database to the private data members
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything worked ok
                return true;

            }
            else
            {
                return false;
            }

        }
    }
}