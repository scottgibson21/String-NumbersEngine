using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringManipulationTests
{
    [TestClass]
    public class PracticeTests
    {
        [TestMethod]
        public void ValueTypes_ints()
        {
            //Arrange
            int x1 = 1;
            int x2 = x1;

            //Act
            x1 = 100;

            //Assert
            Assert.AreEqual(100, x1);
            Assert.AreEqual(1, x2);

        }

        [TestMethod]
        public void ValueTypes_ApproximatePi()
        {
            //Arrange
            decimal pi = ((decimal)355 / (decimal)113);
            decimal roundedPi = Math.Round(pi, 3, MidpointRounding.AwayFromZero);

            //Assert
            Assert.AreEqual(3.142m, roundedPi);

        }

        [TestMethod]
        public void ReferenceTypes_StringCompare()
        {
            //Arrange
            string str1 = "Scott";
            string str2 = str1;
            str1 = "Test";

            //Assert
            Assert.AreEqual("Scott", str2);

        }
    }
}
