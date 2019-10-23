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
    public class LowerCaseTest
    {
        [TestMethod]
        public void ShouldMakeStringLowerCase()
        {
            //Arrange
            var str = "ABC";
            var expected = "abc";
            var myClass = new StringOperations();

            //Act
            var result = myClass.ChangeToLJowerCase(str);

            //Assert
            Assert.AreEqual(expected, result);

        }
    }
}
