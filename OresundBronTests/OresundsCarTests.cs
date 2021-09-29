﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBron.Tests
{
    [TestClass()]
    public class OresundsCarTests
    {
        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void OresundsCarMoreThan7CharactersExceptionTest()
        {
            // Arrange
            OresundsCar car1 = new OresundsCar("12345678", DateTime.Now);

            // Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void PriceTestWithoutBroBizzUsed()
        {
            // Arrange
            OresundsCar car1 = new OresundsCar("1234567", DateTime.Now);

            // Act
            double actualPrice = car1.Price();

            // Assert
            Assert.AreEqual(410, actualPrice);
        }

        [TestMethod()]
        public void PriceTestWithBroBizzUsed()
        {
            // Arrange
            OresundsCar car1 = new OresundsCar("1234567", DateTime.Now);

            // Act
            car1.BroBizzUsed = true;
            double actualPrice = car1.Price();

            // Assert
            Assert.AreEqual(161, actualPrice);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            // Arrange
            OresundsCar car1 = new OresundsCar("1234567", DateTime.Now);

            // Act
            string actualVehicleType = car1.VehicleType();

            // Assert 
            Assert.AreEqual("Oresund car", actualVehicleType);
            // Is Uppercase/Lowercase sensitive
        }
    }
}