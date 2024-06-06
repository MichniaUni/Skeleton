using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;

namespace Testing4
{
    [TestClass]
    public class tstShipment
    {





        //good test data
        //create some test data to pass method
        string ordernum = Convert.ToString(123);
        string street = "some street";
        string city = "some city";
        string postcode = "LE2 7FZ";
        string deliverydate = DateTime.Now.ToShortDateString();






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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 shipmentid = 4;
            //invoke the method
            Found = AnShipment.Find(shipmentid);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestshipmentidFound()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is))
            Boolean OK = true;
            //create some test data with the method
            Int32 shipmentid = 4;
            //invoke the method
            Found = AnShipment.Find(shipmentid);
            //check the shipment id
            if (AnShipment.shipmentid != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestdeliverydateFound()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is))
            Boolean OK = true;
            //create some test data with the method
            Int32 shipmentid = 4;
            //invoke the method
            Found = AnShipment.Find(shipmentid);
            //check the shipment id
            if (AnShipment.deliverydate != Convert.ToDateTime("05/06/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestordernumFound()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is))
            Boolean OK = true;
            //create some test data with the method
            Int32 shipmentid = 4;
            //invoke the method
            Found = AnShipment.Find(shipmentid);
            //check the shipment id
            if (AnShipment.ordernum != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TeststreetFound()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is))
            Boolean OK = true;
            //create some test data with the method
            Int32 shipmentid = 4;
            //invoke the method
            Found = AnShipment.Find(shipmentid);
            //check the shipment id
            if (AnShipment.street != "25 abc")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestcityFound()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is))
            Boolean OK = true;
            //create some test data with the method
            Int32 shipmentid = 4;
            //invoke the method
            Found = AnShipment.Find(shipmentid);
            //check the shipment id
            if (AnShipment.city != "Leicester")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestpostcodeFound()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is))
            Boolean OK = true;
            //create some test data with the method
            Int32 shipmentid = 4;
            //invoke the method
            Found = AnShipment.Find(shipmentid);
            //check the shipment id
            if (AnShipment.postcode != "LE2 7FZ")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestisDeliveryExpressFound()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is))
            Boolean OK = true;
            //create some test data with the method
            Int32 shipmentid = 4;
            //invoke the method
            Found = AnShipment.Find(shipmentid);
            //check the shipment id
            if (AnShipment.isDeliveryExpress != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }





        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string variable to store error mesages
            String Error = "";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }





        /*$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$*/



        [TestMethod]
        public void StreetMinLessOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string street = "";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StreetMin()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string street = "a";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinPlusOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string street = "a";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StreetMaxLessOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string street = "";
            street = street.PadRight(49, 'a');
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void StreetMax()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string street = "";
            street = street.PadRight(50, 'a');
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StreetMid()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string street = "";
            street = street.PadRight(25, 'a');
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StreetMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string street = "";
            street = street.PadRight(51, 'a');
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StreetExtremeMax()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string street = "";
            street = street.PadRight(5000, 'a'); //this should fail
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }





        [TestMethod]
        public void CityMinLessOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string city = "";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CityMin()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string city = "a";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string city = "aa";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string city = "";
            city = city.PadRight(49, 'a');
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CityMax()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string city = "";
            city = city.PadRight(50, 'a');
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CityMid()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string city = "";
            city = city.PadRight(25, 'a');
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string city = "";
            city = city.PadRight(51, 'a');
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CityExtremeMax()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string city = "";
            city = city.PadRight(5000, 'a'); //this should fail
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        /*$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$*/




        [TestMethod]
        public void PostcodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string postcode = "";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PostcodeMin()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string postcode = "a";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string postcode = "aa";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string postcode = "";
            postcode = postcode.PadRight(10, 'a');
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void PostcodeMax()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string postcode = "";
            postcode = postcode.PadRight(10, 'a');
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PostcodeMid()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string postcode = "";
            postcode = postcode.PadRight(5, 'a');
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string postcode = "";
            postcode = postcode.PadRight(11, 'a');
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PostcodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to pass to the method
            string postcode = "";
            postcode = postcode.PadRight(500, 'a'); //this should fail
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DeliveryDateExtremeMin()
        {
            // create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to string variable
            string deliverydate = TestDate.ToString();
            //invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DeliveryDateMinLessOne()
        {
            // create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to string variable
            string deliverydate = TestDate.ToString();
            //invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void DeliveryDateMin()
        {
            // create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            
            //convert the date variable to string variable
            string deliverydate = TestDate.ToString();
            //invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void DeliveryDateMinPlusOne()
        {
            // create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to string variable
            string deliverydate = TestDate.ToString();
            //invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void DeliveryDateExtremeMax()
        {
            // create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to string variable
            string deliverydate = TestDate.ToString();
            //invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void DeliveryDateMax()
        {
            // create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(15);
            //convert the date variable to string variable
            string deliverydate = TestDate.ToString();
            //invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DeliveryDateMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(16);
            //convert the date variable to string variable
            string deliverydate = TestDate.ToString();
            //invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DeliveryDateMaxLessOne()
        {
            // create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(14);
            //convert the date variable to string variable
            string deliverydate = TestDate.ToString();
            //invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DeliveryDateMid()
        {
            // create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(7);
            //convert the date variable to string variable
            string deliverydate = TestDate.ToString();
            //invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateInvalidData()
        {
            // create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //set the expiryDate to a non date value
            string deliverydate = "this is not a date!";
            //invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }



        /*$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$*/





        [TestMethod]
        public void OrdernumMinLessOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string ordernum = "";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrdernumMin()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string ordernum = "1";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrdernumMinPlusOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string ordernum = "2";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrdernumMaxLessOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string ordernum = "99999998";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void OrdernumMax()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string ordernum = "99999999";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrdernumMid()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string ordernum = "9999";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrdernumMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to passs to the method
            string ordernum = "100000000";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrdernumExtremeMax()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string ordernum = "99999999999999999999999999999999999";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrdernumInvalidData()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            // string c=variable to store error mesages
            String Error = "";
            //create some test data to psas to the method
            string ordernum = "This is not a valid!";
            // invoke the method
            Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }

}
