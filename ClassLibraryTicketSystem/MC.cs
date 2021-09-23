using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Class representing a MC object with LicensePLate and Date properties
    /// </summary>
    public class MC : BaseClass
    {
        public MC() { }
        public MC(string licenseplate, DateTime date) : base(licenseplate, date) { }
        public MC(string licenseplate, DateTime date, bool brobiz) : base(licenseplate, date, brobiz) { }
        /// <summary>
        /// Returns the price for this MC, if brobizz was used, it will return 5% less
        /// </summary>
        /// <returns>125</returns>
        public override double Price()
        {
            if (Brobizz)
            {
                return 125 - (125*0.05);
            }
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
