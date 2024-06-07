using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstShipmentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsShipmentCollection AllShipment = new clsShipmentCollection();
            Assert.IsNotNull(AllShipment);

        }

        [TestMethod]

        public void ShipmentListOK()
        {
            clsShipmentCollection AllShipment = new clsShipmentCollection();
            //create some test data
            // in this case data is list of objects
            List<clsShipment> TestList = new List<clsShipment>();
            //add an item to the list
            //create the item of test dta
            clsShipment TestItem = new clsShipment();
            //set its properties
            TestItem.isDeliveryExpress = true;
            TestItem.shipmentid = 1;
            TestItem.street = "some street";
            TestItem.city = "some city";
            TestItem.postcode = "LE2 7FZ";
            TestItem.deliverydate = DateTime.Now;
            TestItem.ordernum = 1;  

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllShipment.ShipmentList = TestList;    
            //test to see the two values are the same
            Assert.AreEqual(AllShipment.ShipmentList, TestList);
        }

        




        [TestMethod]

        public void ThisShipmentPropertyOK()
        {
            clsShipmentCollection AllShipment = new clsShipmentCollection();
            //create some test data
            
            clsShipment TestShipment = new clsShipment();   

          
            //set its properties
            TestShipment.isDeliveryExpress = true;
            TestShipment.shipmentid = 1;
            TestShipment.street = "some street";
            TestShipment.city = "some city";
            TestShipment.postcode = "LE2 7FZ";
            TestShipment.deliverydate = DateTime.Now;
            TestShipment.ordernum = 1;

            
            //assign the data to the property
            AllShipment.ThisShipment = TestShipment;
            //test to see the two values are the same
            Assert.AreEqual(AllShipment.ThisShipment, TestShipment);
        }




        [TestMethod]

        public void ListAndCountOK()
        {
            clsShipmentCollection AllShipment = new clsShipmentCollection();

            //create some test data for the proprty(lis of objects)
            List<clsShipment> TestList = new List<clsShipment>();
            
            //add an itedm to the list
            //create teh itm of test test data

            clsShipment TestItem = new clsShipment();


            //set its properties
            TestItem.isDeliveryExpress = true;
            TestItem.shipmentid = 1;
            TestItem.street = "some street";
            TestItem.city = "some city";
            TestItem.postcode = "LE2 7FZ";
            TestItem.deliverydate = DateTime.Now;
            TestItem.ordernum = 1;

          //item to the test list
          TestList.Add(TestItem);


            //assign the data to the property
            AllShipment.ShipmentList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllShipment.Count, TestList.Count);
        }





        [TestMethod]

        public void AddMethodOK()
        {
            clsShipmentCollection AllShipment = new clsShipmentCollection();




            //create teh itm of test test data

            clsShipment TestItem = new clsShipment();

            //variable to stroe prim key
            Int32 PrimaryKey = 0;


            //set its properties
            TestItem.isDeliveryExpress = true;
            TestItem.shipmentid = 1;
            TestItem.street = "some street";
            TestItem.city = "some city";
            TestItem.postcode = "LE2 7FZ";
            TestItem.deliverydate = DateTime.Now;
            TestItem.ordernum = 1;

            //set THisShipment to the test data
            AllShipment.ThisShipment = TestItem;
            //add the record
            PrimaryKey = AllShipment.Add();
            //set the primary key to test data
            TestItem.shipmentid = PrimaryKey;
            //fint the record
            AllShipment.ThisShipment.Find(PrimaryKey);
            //test to see that two values are thee same
            Assert.AreEqual(AllShipment.ThisShipment, TestItem);


        }

    }
}
