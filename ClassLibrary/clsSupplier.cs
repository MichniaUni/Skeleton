using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public bool Shipmentstatus { get; set; }
        public DateTime ProductionDate { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}