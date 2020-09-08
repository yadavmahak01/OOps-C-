using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            var customerRepo = new CustomerRepositry();
            var custrep = new CustomerRepositry();
            var expected = new Customer(1)
            {
                Emailaddress = "fjkflflf@hd.sd",
                Firstname = "Mahak",
                Lastname = "Yadav",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot row",
                        City = "Gurgaon",
                        State = "Haryana",
                        Country = "India",
                        PostalCode = "122"
                    },
            new Address()
            {
                AddressType = 2,
                StreetLine1 = "Bag End 1",
                StreetLine2 = "Bagshot row 1",
                City = "Gurgaon",
                State = "Haryana",
                Country = "India",
                PostalCode = "122"

            }
                }

            };
            //Act
            var actual = custrep.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.Customerid, actual.Customerid);
            Assert.AreEqual(expected.Emailaddress, actual.Emailaddress);
            Assert.AreEqual(expected.Firstname, actual.Firstname);
            Assert.AreEqual(expected.Lastname, actual.Lastname);
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);

            }

        }
    }
}
