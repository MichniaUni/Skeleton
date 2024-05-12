using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public DateTime RestockDate { get; set; }
        public bool IsActive { get; set; }
        public int ItemID { get; set; }
        public int QuantityInStock { get; set; }
        public string ItemDescription { get; set; }
        public decimal ItemPrice { get; set; }
    }
}