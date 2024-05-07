using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class Stock
            clsStock AnStock = new clsStock();
            //test to see taht is there
            Assert.IsNotNull(AnStock);
        }
    }
}
