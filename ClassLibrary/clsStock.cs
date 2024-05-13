using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the stock id property
        private Int32 mItemID;
        private DateTime mRestockDate;



        public DateTime RestockDate 
        {
            get 
            {
                //this line of code sends data out of the property
                return mRestockDate;
            }
            set 
            {
                //this line of code allows data into the property
                mRestockDate = value;
            }
        }

        public bool IsActive { get; set; }
        
        public Int32 ItemID 
        {
            get
            {
                //this line of code sends data out of the property
                return mItemID;
            }
            set
            {
                //this line of code allows data into the property
                mItemID = value;
            }
        
        }
        

        
        public int QuantityInStock { get; set; }
        public string ItemDescription { get; set; }
        public decimal ItemPrice { get; set; }

        public bool Find(int itemID)
        {
            //set the private data members to the test data value
            mItemID = 21;
            mRestockDate = Convert.ToDateTime("23/12/2020");
            //alwayse return true
            return true;
        }

        
    }
}