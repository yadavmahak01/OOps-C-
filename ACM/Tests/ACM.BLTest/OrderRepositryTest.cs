using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositryTest
    {
        [TestMethod()]
        public void RetrieveOrderDisplayTest()
        {
            //Arrange
            var orderRepo = new OrderRepositry();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };
            //Act
            var actual = orderRepo.Retrieve(10);

            //Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);



        }
    }
}
