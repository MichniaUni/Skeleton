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



        [TestMethod]

        public void UpdateMethodOK()
        {
            clsShipmentCollection AllShipment = new clsShipmentCollection();




            //create teh itm of test test data

            clsShipment TestItem = new clsShipment();

            //variable to stroe prim key
            Int32 PrimaryKey = 0;


            //set its properties
            TestItem.isDeliveryExpress = true;
            
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



            //smodify the records
            TestItem.isDeliveryExpress = false;
            
            TestItem.street = "some street2";
            TestItem.city = "some city2";
            TestItem.postcode = "LE2 7FA";
            TestItem.deliverydate = DateTime.Now;
            TestItem.ordernum = 7;

            //set the record based on new test data
            AllShipment.ThisShipment = TestItem;
            //Update the record
            AllShipment.Update();


            //find the record
            AllShipment.ThisShipment.Find(PrimaryKey);
            //test to see that two values are thee same
            Assert.AreEqual(AllShipment.ThisShipment, TestItem);


        }



        [TestMethod]

        public void DeleteMethodOK()
        {
            clsShipmentCollection AllShipment = new clsShipmentCollection();




            //create the item of test test data

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

            //set ThisShipment to the test data
            AllShipment.ThisShipment = TestItem;
            //add the record
            PrimaryKey = AllShipment.Add();
            //set the primary key to test data
            TestItem.shipmentid = PrimaryKey;
            //fint the record
            AllShipment.ThisShipment.Find(PrimaryKey);
            //delete the record
            AllShipment.Delete();
            //test to see that two values are thee same

            Assert.AreEqual(AllShipment.ThisShipment, TestItem);


        }


        [TestMethod]

        public void ReportByPostCodeMethodOK()
        {
            //create an instance
            clsShipmentCollection AllShipments = new clsShipmentCollection();
            //create an instance for filtered data
            clsShipmentCollection FilteredShipments = new clsShipmentCollection();

            //apply blank string (should return all record)
            FilteredShipments.ReportByPostCode("");
            //test
            Assert.AreEqual(AllShipments.Count, FilteredShipments.Count);
        }


        [TestMethod]

        public void ReportByPostCodeNoneFound()
        {
            
            //create an instance for filtered data
            clsShipmentCollection FilteredShipments = new clsShipmentCollection();

            //apply blank string (should return all record)
            FilteredShipments.ReportByPostCode("xxx xxx");
            //test
            Assert.AreEqual(0, FilteredShipments.Count);
        }

        [TestMethod]

        public void ReportByPostCodeTestDataFoundFound()
        {

            //create an instance for filtered data
            clsShipmentCollection FilteredShipments = new clsShipmentCollection();

            //variable to store the outcome
            Boolean OK = true;

            //apply blank string (should return all record)
            FilteredShipments.ReportByPostCode("yyy yyy");
            //check that the correct number aof records are found
            if (FilteredShipments.Count == 2)
            {
                //check to see if the first record is 25
                if (FilteredShipments.ShipmentList[0].shipmentid != 35)
                {
                    OK = false;
                }

                //check to see if the first record is 26
                if (FilteredShipments.ShipmentList[0].shipmentid != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test
            Assert.IsTrue(OK);
        }
    }
}
