using System;

namespace ClassLibrary
{
    public class clsShipment
    {
        public bool isDeliveryExpress { get; set; }
        public int shipmentid { get; set; }
        public int ordernum { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string postcode { get; set; }
        public DateTime deliverydate { get; set; }
    }
}