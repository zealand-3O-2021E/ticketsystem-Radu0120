using System;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar:Car
    {
        public StoreBaeltCar() { }
        public StoreBaeltCar(string licenseplate, DateTime date) : base(licenseplate, date) { }
        public StoreBaeltCar(string licenseplate, DateTime date, bool brobiz) : base(licenseplate, date, brobiz) { }

        public override double Price()
        {
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                if (Brobizz) return 240 - (240 * 0.2) - ((240-(240 * 0.2))*0.05);
                return 240 - (240 * 0.2);
            }
            if (Brobizz) return 240 - (240 * 0.05);
            return 240;
        }
    }
}
