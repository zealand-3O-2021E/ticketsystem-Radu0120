using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Class representing a car object with LicensePLate and Date properties
    /// </summary>
    public class Car
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// Returns the price for this car
        /// </summary>
        /// <returns>240</returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        /// <returns>Car</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
