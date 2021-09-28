using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Vehicle class
    /// </summary>
    public class Vehicle
    {
        #region Instance Fields
        private string _licensePlate;
        private DateTime _date;
        #endregion

        public Vehicle(string licensePlate, DateTime date)
        {
            _licensePlate = licensePlate;

            if (_licensePlate.Length > 7)
            {
                throw new Exception("License plate cannot have more than 7 characters");
            }
        }


        #region Properties
        /// <summary>
        /// LicensePlate Property
        /// </summary>
        public string LicensePlate
        {
            get { return _licensePlate; }
            set 
            {
                if (_licensePlate.Length > 7)
                {
                    throw new Exception("License Plate cannot have more than 7 characters");
                }

                else
                {
                    _licensePlate = value;
                }
            }
        }

        /// <summary>
        /// Datetime Date property
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        #endregion


        /// <summary>
        /// Virtual method VehicleType
        /// </summary>
        /// <returns>Car</returns>
        public virtual string VehicleType()
        {
            return "Car";
        }

        /// <summary>
        /// Virtual Method Price
        /// </summary>
        /// <returns>240</returns>
        public virtual double Price()
        {
            return 240;
        }


    }
}
