using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundbronTicketLibrary.Tests
{
    [TestClass()]
    public class OresundBronCarTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CarTest()
        {
            var car = new OresundBronCar("12345678", DateTime.Now, false);
            Assert.Fail();
        }
        [TestMethod()]
        public void PriceBrobizzTest()
        {
            var car = new OresundBronCar("123", DateTime.Now, true);
            var output = car.Price();
            Assert.AreEqual(161, output);
        }
        [TestMethod()]
        public void PriceNoBrobizzTest()
        {
            var car = new OresundBronCar("123", DateTime.Now, false);
            var output = car.Price();
            Assert.AreEqual(410, output);
        }
        [TestMethod()]
        public void VehicleTypeTest()
        {
            var car = new OresundBronCar("123", DateTime.Now, false);
            var output = car.VehicleType();
            Assert.AreEqual("Oresund car", output);
        }
    }
}