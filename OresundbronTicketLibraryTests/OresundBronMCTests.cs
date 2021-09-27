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
    public class OresundBronMCTests
    {
        [TestMethod()]
        public void PriceBrobizzTest()
        {
            var mc = new OresundBronMC("123", DateTime.Now, true);
            var output = mc.Price();
            Assert.AreEqual(73, output);
        }
        [TestMethod()]
        public void PriceNoBrobizzTest()
        {
            var mc = new OresundBronMC("123", DateTime.Now, false);
            var output = mc.Price();
            Assert.AreEqual(210, output);
        }
        [TestMethod()]
        public void VehicleTypeTest()
        {
            var mc = new OresundBronMC("123", DateTime.Now, false);
            var output = mc.VehicleType();
            Assert.AreEqual("Oresund MC", output);
        }
    }
}