using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OresundbronTicketLibrary;
using StoreBaeltTicketLibrary;
using ClassLibraryTicketSystem;

namespace ClientTicketSystem.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void BillTest()
        {
            var customer = new Customer("Customer1");
            customer.Trips.Add(new MC("123", DateTime.Now, true));
            customer.Trips.Add(new OresundBronMC("123", DateTime.Now, false));
            customer.Trips.Add(new OresundBronCar("123", DateTime.Now, true));
            customer.Trips.Add(new StoreBaeltCar("123", DateTime.Now, true));

            var output = customer.Bill();

            Assert.AreEqual(717.75, output);
        }

        [TestMethod()]
        public void ListInfoTest()
        {
            var customer = new Customer("Customer1");
            customer.Trips.Add(new MC("123", DateTime.Now, true));
            customer.Trips.Add(new OresundBronMC("123", DateTime.Now, false));
            customer.Trips.Add(new OresundBronCar("123", DateTime.Now, true));
            customer.Trips.Add(new StoreBaeltCar("123", DateTime.Now, true));
            var output = customer.ListInfo();
            Assert.AreEqual("You have 1 car and 1 mb trips on StoreBaelt bridge and 1 car and 1 mb trips on Oresundbron", output);
        }
    }
}