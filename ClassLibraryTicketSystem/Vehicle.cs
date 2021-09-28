using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Vehicle class
    /// </summary>
    public abstract class Vehicle
    {
        #region Instance Fields
        private string _licensePlate;
        private DateTime _date;
        private bool _broBizzUsed = false;
        #endregion


        /// <summary>
        /// base class vehicle constructor. Throws exception if licenseplate is longer than 7 characters
        /// Takes two parameters; a license plate and a date for registration date
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        protected Vehicle(string licensePlate, DateTime date)
        {
            _licensePlate = licensePlate;

            if (_licensePlate.Length > 7)
            {
                throw new Exception("License plate cannot have more than 7 characters");
            }
            _date = date;
            _broBizzUsed = false;
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

        /// <summary>
        /// Brobizz bool property
        /// </summary>
        public bool BroBizzUsed{ get; set;}
        #endregion


        /// <summary>
        /// Virtual method VehicleType
        /// </summary>
        /// <returns>Car</returns>
        public abstract string VehicleType();

        /// <summary>
        /// Virtual Method Price
        /// </summary>
        /// <returns>240</returns>
        public abstract double Price();


    }
}
