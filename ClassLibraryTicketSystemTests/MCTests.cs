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
            MC mc = new MC("12345678", DateTime.Now);

            Assert.Fail();
        }

        [TestMethod()]
        public void PriceTest()
        {
            // Arrange
            MC mc = new MC("123ABC4", DateTime.Now);

            // Act
            double actualPrice = mc.Price();

            // Assert
            Assert.AreEqual(125, actualPrice);
        }

        [TestMethod()]
        public void PriceTestBroBizzUsed()
        {
            // Arrange
            MC mc = new MC("123ABC4", DateTime.Now);

            // Act
            mc.BroBizzUsed = true;
            double actualPrice = mc.Price();

            // Assert
            Assert.AreEqual(118.75, actualPrice);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            // Arrange
            MC mc1 = new MC("123ABC5", DateTime.Now);

            // Act
            string actualVehicleType = mc1.VehicleType();

            // Assert
            Assert.AreEqual("MC", actualVehicleType);
        }
    }
}