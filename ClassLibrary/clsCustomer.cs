using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool isActive { get; set; }
        public DateTime DateAdded { get; set; }
        public long PhoneNumber { get; set; }
        public long Age { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public long CustomerId { get; set; }
    }
}