using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {
        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void CarTest()
        {
            // Arrange
            Car car1 = new Car("12345678", DateTime.Now);

            // Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void PriceTest()
        {
            // Arrange
            Car car1 = new Car("1234A67", DateTime.Now);

            // Act
            double actualPrice = car1.Price();

            // Assert
            Assert.AreEqual(240, actualPrice);
        }

        [TestMethod()]
        public void PriceTestBroBizzUsed()
        {
            // Arrange
            Car car1 = new Car("1234A67", DateTime.Now);

            // Act
            car1.BroBizzUsed = true;
            double actualPrice = car1.Price();

            // Assert
            Assert.AreEqual(228, actualPrice);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            // Arrange
            Car car1 = new Car("1A34567", DateTime.Now);

            // Act
            string actualVehicleType = car1.VehicleType();

            // Assert
            Assert.AreEqual("Car", actualVehicleType);


        }
    }
}