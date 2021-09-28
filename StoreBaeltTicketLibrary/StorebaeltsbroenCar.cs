using System;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class StorebaeltsbroenCar : Vehicle
    {

        public StorebaeltsbroenCar(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            Date = date;
            LicensePlate = licensePlate;
            BroBizzUsed = false;
        }
        public override double Price()
        {
            // If it's a Saturday or Sunday, apply 20% Discount. If Brobizz is also used, 
            // Apply an additional 5% after the 20% is applied
            if(Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                if (BroBizzUsed)
                {
                    double weekendDiscount = (240 * 0.80) * 0.95;
                    return weekendDiscount;
                }

                return 240 * 0.80;

            }
            // If only Brobizz is used and it's a weekday, apply 5% discount
            if (BroBizzUsed)
            {
                return 240 * 0.95;
            }

            //If neither discounts are applied, simply return full price 240
            return 240;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
