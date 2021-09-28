using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC : Vehicle
    {

        public MC(string licensePlate) : base(licensePlate)
        {
            LicensePlate = licensePlate;
        }

        #region Methods
        /// <summary>
        /// Method which returns the price 240
        /// </summary>
        /// <returns>125</returns>
        public override double Price()
        {
            return 125;
        }

        /// <summary>
        /// Method which returns the vehicle type "Car"
        /// </summary>
        /// <returns>MC</returns>
        public override string VehicleType()
        {
            return "MC";
        }
        #endregion
    }
}
