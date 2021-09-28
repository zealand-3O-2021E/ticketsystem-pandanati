using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StorebaeltsbroenCarTests
    {
        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void StorebaeltsbroenLicensePlateLengthTest()
        {
            // Arrange
            StorebaeltsbroenCar car1 = new StorebaeltsbroenCar("12345678", DateTime.Parse("02/10/2021"));

            // Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void StorebæltsbroenPriceTestWeekendWithBroBizz()
        {
            // Arrange
            StorebaeltsbroenCar car1 = new StorebaeltsbroenCar("1234567", DateTime.Parse("3/10/2021"));
           
            // Act
            car1.BroBizzUsed = true;
            double actualPrice = car1.Price();

            // Assert
            //Unit test failed without the 0.01, because the result was around 182.399999999998
            Assert.AreEqual(182.4 , actualPrice, 0.01);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            // Arrange
            StorebaeltsbroenCar car1 = new StorebaeltsbroenCar("1234567", DateTime.Now);

            // Act
            string actualVehicleType = car1.VehicleType();

            // Assert
            Assert.AreEqual("Car", actualVehicleType);
        }
    }
}