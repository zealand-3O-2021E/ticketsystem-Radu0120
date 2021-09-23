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
        public BaseClass()
        {

        }
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
        public BaseClass(string licenseplate, DateTime date)
        {
            if (licenseplate.Length > 7)
            {
                throw new ArgumentException();
            }
            else
            {
                LicensePlate = licenseplate;
                Date = date;
            }
        }
        protected string LicensePlate { get; set; }
        protected bool Brobizz { get; set; }
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
        /// <returns>Car</returns>
        public virtual string VehicleType()
        {
            return "Base";
        }
    }
}
