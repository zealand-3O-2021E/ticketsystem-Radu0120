using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundbronTicketLibrary
{
    /// <summary>
    /// Class for the OresundBronMC model inheriting from the base MC class
    /// </summary>
    public class OresundBronMC : MC
    {
        /// <summary>
        /// Constructor for a OresundBronMC object, inherits from base MC class
        /// </summary>
        /// <param name="licenseplate">License plate</param>
        /// <param name="date">Date</param>
        /// <param name="brobizz">If brobizz was used or not</param>
        public OresundBronMC(string licenseplate, DateTime date, bool brobizz) : base(licenseplate, date, brobizz) { }
        /// <summary>
        /// Returns the price
        /// </summary>
        /// <returns>210, or 73 if brobizz was used</returns>
        public override double Price()
        {
            if (Brobizz) return 73;
            return 210;
        }
        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        /// <returns>"Oresund MC"</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
