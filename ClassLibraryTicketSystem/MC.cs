using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Class representing a MC object with LicensePLate and Date properties
    /// </summary>
    public class MC : BaseClass
    {
        /// <summary>
        /// Returns the price for this MC
        /// </summary>
        /// <returns>125</returns>
        public override double Price()
        {
            return 125;
        }
        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        /// <returns>MC</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
