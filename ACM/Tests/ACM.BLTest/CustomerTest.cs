using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {

        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer cs = new Customer() //Objects are reference type
            {
                Firstname = "Mahak",
                Lastname = "Yadav"
            };
            //Act
            String expected = "Yadav Mahak";
            String actual = cs.Fullname;
            //Assert
            Assert.AreEqual(actual, expected);

        }
        /*[TestMethod]
        public void FullNameFirstEmplty()
        {
            Customer cs = new Customer()
            {
                Lastname = "Yadav"  
            };
            //Act
            String expected = "Yadav";
            String actual = cs.Fullname;
            //Assert
            Assert.AreEqual(expected,actual);

        }
        [TestMethod]
        public void FullNameLastEmplty()
        {
            Customer cs = new Customer()
            {
                Firstname = "Mahak",
            };
            //Act
            String expected = "Mahak";
            String actual = cs.Fullname;
            //Assert
            Assert.AreEqual(expected, actual);

        }*/

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.Firstname = "Mahak";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.Firstname = "Mohak";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c1.Firstname = "Yadav";
            Customer.InstanceCount += 1;


            //Act
            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer
            {
                Lastname = "Yadav",
                Emailaddress = "jfhgkgkg@gmail.com"
            };
            var expected = false;

            //..Act
            var actual = customer.Validate();

            //..Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //..Arrange
            var customer = new Customer
            {
                Emailaddress = "jfhgkgkg@gmail.com"
            };
            var expected = false;

            //..Act
            var actual = customer.Validate();

            //..Assert

            Assert.AreEqual(expected, actual);
        }

    }
}
