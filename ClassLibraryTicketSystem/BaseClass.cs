using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Abstract base class used for inheritance
    /// </summary>
    public abstract class BaseClass
    {
        /// <summary>
        /// Constructor for a Base object
        /// </summary>
        /// <param name="licenseplate">License plate</param>
        /// <param name="date">Date</param>
        /// <param name="brobizz">If brobizz was used or not</param>
        public BaseClass(string licenseplate, DateTime date, bool brobizz)
        {
            if (licenseplate.Length > 7)
            {
                throw new ArgumentException();
            }
            else
            {
                LicensePlate = licenseplate;
                Brobizz = brobizz;
                Date = date;
            }
        }
        /// <summary>
        /// License plate property, of the string type
        /// </summary>
        protected string LicensePlate { get; set; }
        /// <summary>
        /// Boolean representing whether brobizz was used or not
        /// </summary>
        protected bool Brobizz { get; set; }
        /// <summary>
        /// Date property, of the DateTime type
        /// </summary>
        protected DateTime Date { get; set; }
        /// <summary>
        /// Returns the price
        /// </summary>
        /// <returns>100</returns>
        public virtual double Price()
        {
            if (Brobizz)
            {
                return 100 - 5%100;
            }
            return 100;
        }
        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        /// <returns>Base</returns>
        public virtual string VehicleType()
        {
            return "Base";
        }
    }
}
