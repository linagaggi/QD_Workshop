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
            string x = "first";
            string y = "second";
            var expected = "x * y = 6";
            IConjoin mathOperations = new Conjoin(x, y);

            //Act
            var result = mathOperations.ConjoinFunc();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }

    public class ConjoinTest
    {

    }

}