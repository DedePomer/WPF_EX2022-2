using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SaleLibrary;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetSale_SmallUsualValue()
        {
            int actual, expendet;
            actual = Class1.SaleCalc(3, 100);
            expendet = 5;
            Assert.AreEqual(expendet, actual);
        }

        [TestMethod]
        public void GetSale_BigUsualValue()
        {
            int actual, expendet;
            actual = Class1.SaleCalc(3, 5050);
            expendet = 15;
            Assert.AreEqual(expendet, actual);
        }

        [TestMethod]
        public void GetSale_SmallNegayiveValue()
        {
            int actual, expendet;
            actual = Class1.SaleCalc(-3, 500);
            expendet = 1;
            Assert.AreEqual(expendet, actual);
        }

        [TestMethod]
        public void GetSale_BigNegayiveValue()
        {
            int actual, expendet;
            actual = Class1.SaleCalc(-3, 5050);
            expendet = 10;
            Assert.AreEqual(expendet, actual);
        }

        [TestMethod]
        public void GetSale_BigCountOrder()
        {
            int actual, expendet;
            actual = Class1.SaleCalc(15, 6400);
            expendet = 27;
            Assert.AreEqual(expendet, actual);
        }
    }
}
