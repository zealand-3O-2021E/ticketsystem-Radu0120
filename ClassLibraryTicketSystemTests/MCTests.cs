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
    }
}