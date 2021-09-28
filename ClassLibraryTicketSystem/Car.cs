using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class Car : Vehicle
    {
        public Car(string licensePlate) : base(licensePlate)
        {
            LicensePlate = licensePlate;
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
