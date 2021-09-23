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
        public Car(string licenseplate, DateTime date, bool brobiz) : base(licenseplate, date, brobiz) { }
        /// <summary>
        /// Returns the price for this car, if brobizz was used, it will return 5% less
        /// </summary>
        /// <returns>240</returns>
        public override double Price()
        {
            if (Brobizz)
            {
                return 240 - (240*0.05);
            }
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
