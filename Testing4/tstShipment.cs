using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstShipment
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //test to see that it exists
            Assert.IsNotNull(AnShipment);
        }
        

        [TestMethod]
        public void isDeliveryExpressPropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign data to the property
            AnShipment.isDeliveryExpress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.isDeliveryExpress, TestData);   
        }


        [TestMethod]
        public void shipmentidPropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign data to the property
            AnShipment.shipmentid = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.shipmentid, TestData);
        }


        [TestMethod]
        public void ordernumPropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign data to the property
            AnShipment.ordernum = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.ordernum, TestData);
        }

        [TestMethod]
        public void streetPropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            string TestData = "some street";
            //assign data to the property
            AnShipment.street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.street, TestData);
        }


        [TestMethod]
        public void cityPropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            string TestData = "watercity";
            //assign data to the property
            AnShipment.city = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.city, TestData);
        }


        [TestMethod]
        public void postcodePropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            string TestData = "LE2 7FZ";
            //assign data to the property
            AnShipment.postcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.postcode, TestData);
        }

        [TestMethod]
        public void deliverydatePropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AnShipment.deliverydate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.deliverydate, TestData);
        }
    }

}
