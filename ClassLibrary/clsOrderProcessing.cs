using System;

namespace ClassLibrary
{
    public class clsOrderProcessing
    {
        public clsOrderProcessing()
        {
        }

        public bool IsCancelled { get; set; }
        public DateTime DateAdded { get; set; }
        public string OrderStatus { get; set; }
        public int OrderId { get; set; }
        public string PaymentMethod { get; set; }
    }
}