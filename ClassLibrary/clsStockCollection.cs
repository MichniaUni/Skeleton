using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mItemList = new List<clsStock>();

        public List<clsStock> ItemList
        {
            get
            {
                //return the private data
                return mItemList;
            }
            set
            {
                //set the private data
                mItemList = value;
            }
        }
        public int Count 
        {
            get
            {
                //return the count of the list
                return mItemList.Count;
            }
            set
            {

            }
        }

        public clsStock ThisItem { get; set; }
    }
}