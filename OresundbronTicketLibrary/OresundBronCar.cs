using System;
using ClassLibraryTicketSystem;

namespace OresundbronTicketLibrary
{
    /// <summary>
    /// Class for the OresundBron car model, inherits from the base Car class
    /// </summary>
    public class OresundBronCar : Car
    {
        /// <summary>
        /// Constructor for a OresundBronCar object, inherits from the base Car class
        /// </summary>
        /// <param name="licenseplate">License plate</param>
        /// <param name="date">Date</param>
        /// <param name="brobizz">If brobizz was used or not</param>
        public OresundBronCar(string licenseplate, DateTime date, bool brobizz) : base(licenseplate, date, brobizz) { }

        /// <summary>
        /// Method that returns the price
        /// </summary>
        /// <returns>410, or 161 if brobizz was used</returns>
        public override double Price()
        {
            if (Brobizz) return 161;
            return 410;
        }
        /// <summary>
        /// Method that returns the vehicle type
        /// </summary>
        /// <returns>"Oresund car"</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
