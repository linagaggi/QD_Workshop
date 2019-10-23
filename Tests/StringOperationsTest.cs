using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QDWorkshop;

namespace Tests
{
    [TestClass]
    public class StringOperationsTest
    {
        [TestMethod]
        public void ShouldMakeUppercase()
        {
            //Arrange
            var str = "This is a Test String";
            var expected = "THIS IS A TEST STRING";
            IStringOperations stringOps = new StringOperations();
            //Act
            var result = stringOps.Uppercase(str);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
