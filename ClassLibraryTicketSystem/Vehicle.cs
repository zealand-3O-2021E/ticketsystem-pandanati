using System;

namespace ClassLibraryTicketSystem
{
    public class Vehicle
    {
        #region Instance Fields
        private string _licensePlate;
        private DateTime _date;
        #endregion

        public Vehicle(string licensePlate)
        {
            _licensePlate = licensePlate;

            if (_licensePlate.Length > 7)
            {
                throw new Exception("License plate cannot have more than 7 characters");
            }
        }

        #region Properties
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

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        #endregion

        public virtual string VehicleType()
        {
            return "Car";
        }

        public virtual double Price()
        {
            return 240;
        }


    }
}
