using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplierUsers
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class we want
            clsSupplierUser AnUser= new clsSupplierUser();
            //test te see that it exists
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIdPropertyOK()
        {
            //create an instance of class we want
            clsSupplierUser AnUser = new clsSupplierUser();
            //create some test data to assign to the property
            Int32 TestData = 5;
            //assign the data to the property
            AnUser.UserId=TestData;
            //test tpo see thst two values are same
            Assert.AreEqual(AnUser.UserId, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of class we want
            clsSupplierUser AnUser = new clsSupplierUser();
            //create some test data to assign to the property
            string TestData = "Anju";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test tpo see thst two values are same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of class we want
            clsSupplierUser AnUser = new clsSupplierUser();
            //create some test data to assign to the property
           string TestData = "P2786795";
            //assign the data to the property
            AnUser.Password = TestData;
            //test tpo see thst two values are same
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of class we want
            clsSupplierUser AnUser = new clsSupplierUser();
            //create some test data to assign to the property
            string TestData = "Supplier";
            //assign the data to the property
            AnUser.Department= TestData;
            //test tpo see thst two values are same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of class we want
            clsSupplierUser AnUser = new clsSupplierUser();
            //create a boolean variable to store the result of the validation
            Boolean Found= false;
            //create some test data to use with the method
            string UserName = "Anju";
            string Password = "P2786795";
            //invoke the method
            Found= AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestUserNamePasswordFound()
        {
            //create an instance of class we want
            clsSupplierUser AnUser = new clsSupplierUser();
            //create a boolean variable to store the result of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Anju";
            string Password = "P2786795";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check the user id property
            if(AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

    }
}
