using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StoreBaeltCarTests
    {
        [TestMethod()]
        public void PriceBrobizzTest()
        {
            var car = new StoreBaeltCar("123", DateTime.Now, true);
            var output = car.Price();
            Assert.AreEqual(228, output);
        }
        [TestMethod()]
        public void PriceNoBrobizzTest()
        {
            var car = new StoreBaeltCar("123", DateTime.Now, false);
            var output = car.Price();
            Assert.AreEqual(240, output);
        }
        [TestMethod()]
        public void PriceWeekendTest()
        {
            var car = new StoreBaeltCar("123", DateTime.Parse("26-09-2021"), false);
            var output = car.Price();
            Assert.AreEqual(192, output);
        }
        [TestMethod()]
        public void PriceNotWeekendTest()
        {
            var car = new StoreBaeltCar("123", DateTime.Parse("27-09-2021"), false);
            var output = car.Price();
            Assert.AreEqual(240, output);
        }
        [TestMethod()]
        public void PriceWeekendBrobizzTest()
        {
            var car = new StoreBaeltCar("123", DateTime.Parse("26-09-2021"), true);
            var output = car.Price();
            Assert.AreEqual(182.4, output);
        }
    }
}