using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CarTest()
        {
            var car = new Car("12345678",DateTime.Now, false);
            Assert.Fail();
        }
        [TestMethod()]
        public void PriceTest()
        {
            var car = new Car("1234", DateTime.Now, false);
            var output = car.Price();
            Assert.AreEqual(240,output);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var car = new Car("1234", DateTime.Now, false);
            var output = car.VehicleType();
            Assert.AreEqual("Car", output);
        }
        [TestMethod()]
        public void BrobizzTest()
        {
            var car = new Car("123", DateTime.Now, true);
            var output = car.Price();
            Assert.AreEqual(228, output);
        }
    }
}