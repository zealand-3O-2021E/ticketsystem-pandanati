using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBron
{
    public class OresundsMC : Vehicle
    {

        public OresundsMC(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            LicensePlate = licensePlate;
            Date = date;
            BroBizzUsed = false;
        }

        public override double Price()
        {
            if (BroBizzUsed)
            {
                //If BroBizzUsed is true, then the price will be 73 kr.
                return 73;
            }

            // If BroBizzUsed is not used, then the price will be the standard price, 210 kr.
            return 210;
        }


        public override string VehicleType()
        {
            return "Oresund MC";
        }

    }
}
