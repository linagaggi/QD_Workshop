using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QDWorkshop;

namespace Tests
{
    [TestClass]
    public class MathOperationsTest
    {
        [TestMethod]
        public void ShouldMultiply2Integers()
        {
            //Arrange
            var x = 2;
            var y = 3;
            var expected = "x * y = 6";
            IMathOperations mathOperations = new MathOperations(x, y);

            //Act
            var result = mathOperations.Multiply();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
