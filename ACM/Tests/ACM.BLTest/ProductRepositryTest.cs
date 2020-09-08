using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositryTest
    {

        [TestMethod()]
        public void SaveTestValid()
        {
            //Arrange
            var prodRepo = new ProductRepositry();
            var updateProduct = new Product(2)
            {
                CurrentPrice = 15M,
                ProductDescription = "Made for cool ",
                ProductName = "Roses",
                HasChanges = true
            };

            var actual = prodRepo.Save(updateProduct);

            //Assert

            Assert.AreEqual(true, actual);
        }
        [TestMethod()]
        public void SaveTestMissingPrice()
        {
            //Arrange
            var prodRepo = new ProductRepositry();
            var updateProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Made is cool ",
                ProductName = "Roses",
                HasChanges = true
            };

            var actual = prodRepo.Save(updateProduct);

            //Assert

            Assert.AreEqual(false, actual);
        }


        [TestMethod()]
        public void RetrieveTest()
        {
            //Arrange
            var productRepo = new ProductRepositry();
            var expected = new Product(2)
            {
                CurrentPrice = 13.4M,
                ProductDescription = "Made for happiness ",
                ProductName = "Roses"

            };
            //Act
            var actual = productRepo.Retrieve(2);

            //Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);


        }
    }
}
