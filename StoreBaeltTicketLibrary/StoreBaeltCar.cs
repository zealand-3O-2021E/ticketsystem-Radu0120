using System;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Class used for the Storebaelt client, expanded base car class
    /// </summary>
    public class StoreBaeltCar:Car
    {
        /// <summary>
        /// Constructor for a StoreBaeltCar object, inherits from the base Car class
        /// </summary>
        /// <param name="licenseplate">License plate</param>
        /// <param name="date">Date</param>
        /// <param name="brobizz">If brobizz was used or not</param>
        public StoreBaeltCar(string licenseplate, DateTime date, bool brobizz) : base(licenseplate, date, brobizz) { }

        /// <summary>
        /// Returns the price
        /// </summary>
        /// <returns>240 if no discounts are applied, a 20% discount if its a weekend day and a 5% discount if brobizz was used</returns>
        public override double Price()
        {
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                if (Brobizz) return 240 - (240 * 0.2) - ((240-(240 * 0.2))*0.05);
                return 240 - (240 * 0.2);
            }
            if (Brobizz) return 240 - (240 * 0.05);
            return 240;
        }
    }
}
