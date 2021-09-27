using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Class representing a MC object, inherits from the base class
    /// </summary>
    public class MC : BaseClass
    {
        /// <summary>
        /// Constructor for a MC object
        /// </summary>
        /// <param name="licenseplate">License plate</param>
        /// <param name="date">Date</param>
        /// <param name="brobizz">If brobizz was used or not</param>
        public MC(string licenseplate, DateTime date, bool brobizz) : base(licenseplate, date, brobizz) { }
        /// <summary>
        /// Returns the price for this MC, if brobizz was used, it will return 5% less
        /// </summary>
        /// <returns>125, or 5% less if brobizz was used</returns>
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
