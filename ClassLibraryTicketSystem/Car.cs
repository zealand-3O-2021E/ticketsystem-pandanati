using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Car class which contains overriding methods Price(double) and Vehicle Type(string). Inherits from Vehicle
    /// </summary>
    public class Car : Vehicle
    {
        public Car(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }
        /// <summary>
        /// Method which returns the price 240
        /// </summary>
        /// <returns>240</returns>
        #region Methods
        public override double Price()
        {
            return 240;
        }
        
        /// <summary>
        /// Method which retusn the vehicle type "Car"
        /// </summary>
        /// <returns>Car</returns>
        public override string VehicleType()
        {
            return "Car";
        }
        #endregion
    }
}
