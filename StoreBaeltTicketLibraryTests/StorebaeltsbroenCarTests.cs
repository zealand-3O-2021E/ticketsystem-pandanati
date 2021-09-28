using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StorebaeltsbroenCarTests
    {
        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void StorebaeltsbroenCarTest()
        {
            // Arrange
            StorebaeltsbroenCar car1 = new StorebaeltsbroenCar("12345A78", DateTime.Now);

            // Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void StorebæltsbroenWeekendWithBroBizzPriceTest()
        {
            // Arrange
            StorebaeltsbroenCar car1 = new StorebaeltsbroenCar("1234567", DateTime.Parse("02/10/2021"));

            // Act


            Assert.Fail();
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PriceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void VehicleTypeTest1()
        {
            Assert.Fail();
        }
    }
}