using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Common1Test
{
    [TestClass]
    public class LoggingTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();
            var cust = new Customer(1)
            {
                Emailaddress = "mask@fkf.cv",
                Firstname = "Mahak",
                Lastname = "Yadav",
                AddressList = null
            };
            //changedItems.Add(cust);

            var product = new Product(2)
            {
                ProductName = "Kj",
                ProductDescription = "Garden ",
                CurrentPrice = 6M
            };
            // changedItems.Add(product);

            // LoggingService.WriteToFile(changedItems);
        }
    }
}
