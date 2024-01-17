using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChocolateLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateLib.Tests
{
    [TestClass]
    public class EasterEggsRepositoryTests
    {
        private EasterEggsRepository repository;

        [TestInitialize]
        public void Setup()
        {
            repository = new EasterEggsRepository();
        }

        [TestMethod]
        public void Get_ReturnsListOfEasterEggs()
        {
            var result = repository.Get();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(System.Collections.Generic.List<EasterEgg>));
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void GetByProductNo_ValidProductNo_ReturnsEasterEgg()
        {
            int validProductNo = 1;

            var result = repository.GetByProductNo(validProductNo);

            Assert.IsNotNull(result);
            Assert.AreEqual(validProductNo, result.ProductNo);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void GetByProductNo_InvalidProductNo_ThrowsException()
        {
            int invalidProductNo = 99;

            repository.GetByProductNo(invalidProductNo);
        }

        [TestMethod]
        public void GetLowStock_ReturnsListOfEasterEggs()
        {
            int stockLevel = 25;

            var result = repository.GetLowStock(stockLevel);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(System.Collections.Generic.List<EasterEgg>));
            Assert.IsTrue(result.Count > 0);
        }
    }
}