using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Common1Test
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InterSpacesTestValid()
        {
            var source = "MahakYad";
            var expected = "Mahak Yad";
            //var handler = new StringHandler();

            //static so using class
            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void InterSpacesWithExistingSpace()
        {
            var source = "Mahak Yad";
            var expected = "Mahak Yad";
            //var handler = new StringHandler();

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);



        }
    }
}
