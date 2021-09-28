using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// MC class which contains overriding methods: Price(double) and Vehicle Type(string). Inherits from Vehicle
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// MC constructor with license plate and datetime, inherits from Vehicle
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        public MC(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            LicensePlate = licensePlate;
            Date = date;
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
