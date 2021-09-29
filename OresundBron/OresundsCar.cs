using System;
using ClassLibraryTicketSystem;

namespace OresundBron
{
    public class OresundsCar : Vehicle
    {

        public OresundsCar(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            LicensePlate = licensePlate;
            Date = date;
            BroBizzUsed = false;
        }

        public override double Price()
        {
            if (BroBizzUsed)
            {
                return 161;
            }

            return 410;
        }

        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
