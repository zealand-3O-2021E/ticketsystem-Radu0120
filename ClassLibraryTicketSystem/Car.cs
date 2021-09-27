using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Class representing a car object
    /// </summary>
    public class Car : BaseClass
    {
        /// <summary>
        /// Constructor for a Car object, inherits from the base class
        /// </summary>
        /// <param name="licenseplate">License plate</param>
        /// <param name="date">Date</param>
        /// <param name="brobizz">If brobizz was used or not</param>
        public Car(string licenseplate, DateTime date, bool brobizz) : base(licenseplate, date, brobizz) { }
        /// <summary>
        /// Returns the price for this car, if brobizz was used, it will return 5% less
        /// </summary>
        /// <returns>240, or 5% less if brobizz was used</returns>
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
