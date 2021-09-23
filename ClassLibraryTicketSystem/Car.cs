using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Class representing a car object with LicensePLate and Date properties
    /// </summary>
    public class Car : BaseClass
    {
        public Car() { }
        public Car(string licenseplate, DateTime date) : base(licenseplate, date) { }
        /// <summary>
        /// Returns the price for this car
        /// </summary>
        /// <returns>240</returns>
        public override double Price()
        {
            return 240;
        }
        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        /// <returns>Car</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
