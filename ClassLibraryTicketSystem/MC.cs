using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Class representing a MC object with LicensePLate and Date properties
    /// </summary>
    public class MC
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// Returns the price for this car
        /// </summary>
        /// <returns>240</returns>
        public double Price()
        {
            return 125;
        }
        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        /// <returns>Car</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
