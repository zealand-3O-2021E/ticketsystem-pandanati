using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class Car
    {
        #region Instance Fields
        private string _licensePlate;
        private DateTime _date;
        #endregion

        #region Properties
        public string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        #endregion

        /// <summary>
        /// Method which returns the price 240
        /// </summary>
        /// <returns>240</returns>
        #region Methods
        public double Price()
        {
            return 240;
        }
        
        /// <summary>
        /// Method which retusn the vehicle type "Car"
        /// </summary>
        /// <returns>Car</returns>
        public string VehicleType()
        {
            return "Car";
        }
        #endregion
    }
}
