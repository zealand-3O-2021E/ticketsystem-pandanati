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
    public class MCTests
    {
        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void MCTest()
        {
            // Arrange
            MC mc = new MC("12345678");

            Assert.Fail();
        }

        [TestMethod()]
        public void PriceTest()
        {
            // Arrange
            MC mc = new MC("123ABC4");

            // Act
            double actualPrice = mc.Price();

            // Assert
            Assert.AreEqual(125, actualPrice);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            // Arrange
            MC mc1 = new MC("123ABC5");

            // Act
            string actualVehicleType = mc1.VehicleType();

            // Assert
            Assert.AreEqual("MC", actualVehicleType);
        }
    }
}