using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;
using StoreBaeltTicketLibrary;
using OresundbronTicketLibrary;

namespace ClientTicketSystem
{
    /// <summary>
    /// Customer class for storing and creating trips
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Name property to identify different customers
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// List containing BaseClass objects for storage
        /// </summary>
        public List<BaseClass> Trips;
        /// <summary>
        /// Basic constructor to initialize a customer object
        /// </summary>
        /// <param name="name">Name of the customer</param>
        public Customer(string name)
        {
            Name = name;
            Trips = new List<BaseClass>();
        }
        /// <summary>
        /// A method that returns the total bill for the customer
        /// </summary>
        /// <returns>The sum of the prices of all the items in the Trips list</returns>
        public double Bill()
        {
            double sum = 0;
            foreach(var item in Trips)
            {
                sum = sum + item.Price();
            }
            return sum;
        }
        /// <summary>
        /// A method used for informative purposes about trips
        /// </summary>
        /// <returns>A message containing how many trips of each time the customer has</returns>
        public string ListInfo()
        {
            int SBcar = 0; int SBMC = 0; int OBcar = 0; int OBMC = 0;
            foreach (var item in Trips)
            {
                if (item.GetType() == typeof(StoreBaeltCar)) SBcar++;
                else if (item.GetType() == typeof(OresundBronMC)) OBMC++;
                else if (item.GetType() == typeof(OresundBronCar)) OBcar++;
                else if (item.GetType() == typeof(MC)) SBMC++;
            }
            return $"You have {SBcar} car and {SBMC} mb trips on StoreBaelt bridge and {OBcar} car and {OBMC} mb trips on Oresundbron";
        }
    }
}
