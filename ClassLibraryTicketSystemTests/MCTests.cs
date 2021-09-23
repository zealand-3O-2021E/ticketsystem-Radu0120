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
    public class MCTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void MCTest()
        {
            var mc = new MC("12345678", DateTime.Now);
            Assert.Fail();
        }
        [TestMethod()]
        public void PriceTest()
        {
            var mc = new MC();
            var output = mc.Price();
            Assert.AreEqual(125, output);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var mc = new MC();
            var output = mc.VehicleType();
            Assert.AreEqual("MC", output);
        }
        [TestMethod()]
        public void BrobizzTest()
        {
            var mc = new MC("123", DateTime.Now, true);
            var output = mc.Price();
            Assert.AreEqual(118.75, output);
        }
    }
}