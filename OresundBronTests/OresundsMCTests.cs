using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBron.Tests
{
    [TestClass()]
    public class OresundsMCTests
    {
        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void OresundsMCMoreThan7CharactersTest()
        {
            // Arrange
            OresundsMC MC1 = new OresundsMC("12345678", DateTime.Now);

            // Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void PriceTestWithBroBizzUsed()
        {
            // Arrange
            OresundsMC MC1 = new OresundsMC("1234567", DateTime.Now);

            // Act
            MC1.BroBizzUsed = true;
            double actualPrice = MC1.Price();

            // Assert
            Assert.AreEqual(73, actualPrice);
        }


        [TestMethod()]
        public void PriceTestWithoutBroBizzUsed()
        {
            // Arrange
            OresundsMC MC1 = new OresundsMC("1234567", DateTime.Now);

            // Act
            double actualPrice = MC1.Price();

            // Assert
            Assert.AreEqual(210, actualPrice);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            // Arrange
            OresundsMC MC1 = new OresundsMC("1234567", DateTime.Now);

            // Act
            string actualVehicleType = MC1.VehicleType();

            // Assert
            Assert.AreEqual("Oresund MC", actualVehicleType);
        }
    }
}