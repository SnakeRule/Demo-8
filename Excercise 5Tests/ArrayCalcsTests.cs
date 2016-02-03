using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excercise_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_5.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            // Arrange
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 25.60;
            // Act
            double actual = ArrayCalcs.Sum(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AverageTest()
        {
            // Arrange
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 3.66;
            // Act
            double actual = ArrayCalcs.Average(array);
            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void MinTest()
        {
            
        }

        [TestMethod()]
        public void MaxTest()
        {
            
        }
    }
}