using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers;
using Numbers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersTests
{
    [TestClass]
    public class NumberManagerTests
    {
        INumbersManager _numbersManager;

        [TestInitialize]
        public void Initialize()
        {
            _numbersManager = new NumbersManager();
        }
        [TestMethod]
        public void ApproximatePiWithOddFractions_2DecimalPlaces()
        {
            //Arrange
            int numDecimalPlaces = 2;

            //Act
            decimal result = _numbersManager.ApproximatePiWithOddFractions(numDecimalPlaces);

            //Assert
            Assert.AreEqual(3.14m, result);
        }

        [TestMethod]
        public void ApproximatePiWithOddFractions_3DecimalPlaces()
        {
            //Arrange
            int numDecimalPlaces = 3;

            //Act
            decimal result = _numbersManager.ApproximatePiWithOddFractions(numDecimalPlaces);

            //Assert
            Assert.AreEqual(3.141m, result);
        }

        [TestMethod]
        public void ApproximatePiWithFraction_2DecimalPlaces()
        {
            //Arrange
            int numDecimalPlaces = 2;

            //Act
            decimal result = _numbersManager.ApproximatePiWithFraction(numDecimalPlaces);

            //Assert
            Assert.AreEqual(3.14m, result);
        }

        [TestMethod]
        public void ApproximatePiWithFraction_3DecimalPlaces()
        {
            //Arrange
            int numDecimalPlaces = 3;

            //Act
            decimal result = _numbersManager.ApproximatePiWithOddFractions(numDecimalPlaces);

            //Assert
            Assert.AreEqual(3.141m, result);
        }

        [TestMethod]
        public void ApproximateE_3DecimalPlaces()
        {
            //Arrange
            int numDecimalPlaces = 3;

            //Act
            decimal result = _numbersManager.ApproximateE(numDecimalPlaces);

            //Assert
            Assert.AreEqual(2.718m, result);
        }

        [TestMethod]

        public void GenerateFibonacciSequence_negativeInput()
        {
            //Arrange
            int numToGenerate = -1;

            //Act
            List<int> resultList = _numbersManager.GenerateFibonacciSequence(numToGenerate);

            //Assert
            Assert.AreEqual(null, resultList);
        }

        [TestMethod]

        public void GenerateFibonacciSequence_Generate1()
        {
            //Arrange
            int numToGenerate = 1;
            List<int> expectedList = new List<int> { 1 };

            //Act
            List<int> resultList = _numbersManager.GenerateFibonacciSequence(numToGenerate);

            //Assert
            Assert.AreEqual(true, expectedList.SequenceEqual(resultList));
        }

        [TestMethod]

        public void GenerateFibonacciSequence_Generate2()
        {
            //Arrange
            int numToGenerate = 2;
            List<int> expectedList = new List<int> { 1, 1 };

            //Act
            List<int> resultList = _numbersManager.GenerateFibonacciSequence(numToGenerate);

            //Assert
            Assert.AreEqual(true, expectedList.SequenceEqual(resultList));
        }

        [TestMethod]

        public void GenerateFibonacciSequence_Generate4()
        {
            //Arrange
            int numToGenerate = 4;
            List<int> expectedList = new List<int> { 1, 1, 2, 3 };

            //Act
            List<int> resultList = _numbersManager.GenerateFibonacciSequence(numToGenerate);

            //Assert
            Assert.AreEqual(true, expectedList.SequenceEqual(resultList));
        }

        [TestMethod]
        public void GenerateFibonacciSequence_Generate7()
        {
            //Arrange
            int numToGenerate = 7;
            List<int> expectedList = new List<int> { 1, 1, 2, 3, 5, 8, 13 };

            //Act
            List<int> resultList = _numbersManager.GenerateFibonacciSequence(numToGenerate);

            //Assert
            Assert.AreEqual(true, expectedList.SequenceEqual(resultList));
        }

        [TestMethod]
        public void GeneratePrimeFactorization_12()
        {
            //Arrange
            int input = 12;
            List<int> primeFactors = new List<int> { 2, 2, 3 };

            //Act
            List<int> resultList = _numbersManager.GeneratePrimeFactorization(input);

            //Assert
            Assert.AreEqual(true, primeFactors.SequenceEqual(resultList));
        }

        [TestMethod]
        public void GeneratePrimeFactorization_29()
        {
            //Arrange
            int input = 29;
            List<int> primeFactors = new List<int> { 29 };

            //Act
            List<int> resultList = _numbersManager.GeneratePrimeFactorization(input);

            //Assert
            Assert.AreEqual(true, primeFactors.SequenceEqual(resultList));
        }

        [TestMethod]
        public void GeneratePrimeFactorization_380()
        {
            //Arrange
            int input = 380;
            List<int> primeFactors = new List<int> { 2, 2, 5, 19 };

            //Act
            List<int> resultList = _numbersManager.GeneratePrimeFactorization(input);

            //Assert
            Assert.AreEqual(true, primeFactors.SequenceEqual(resultList));
        }

        [TestMethod]
        public void GeneratePrimeFactorization_14523()
        {
            //Arrange
            int input = 14523;
            List<int> primeFactors = new List<int> { 3, 47, 103 };

            //Act
            List<int> resultList = _numbersManager.GeneratePrimeFactorization(input);

            //Assert
            Assert.AreEqual(true, primeFactors.SequenceEqual(resultList));
        }

        [TestMethod]
        public void FetchNextPrimeNumber_NetativeNum()
        {
            //Arrange
            int input = -7;

            //Act
            int result = _numbersManager.FetchNextPrimeNumber(input);

            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FetchNextPrimeNumber_54()
        {
            //Arrange
            int input = 54;

            //Act
            int result = _numbersManager.FetchNextPrimeNumber(input);

            //Assert
            Assert.AreEqual(59, result);
        }

        [TestMethod]
        public void CalculateTileCost_w8_h2_c100()
        {
            //Arrange
            float w = 8.00f;
            float h = 2.00f;
            decimal costPerUnit = 100.00m;

            //Act
            decimal result = _numbersManager.CalculateTileCost(w, h, costPerUnit);

            //Assert
            Assert.AreEqual(1600.00m, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Width and height parameters must be greater than zero")]
        public void CalculateTileCost_negativeW_h2_c100()
        {
            //Arrange
            float w = -8.00f;
            float h = 2.00f;
            decimal costPerUnit = 100.00m;

            //Act
            decimal result = _numbersManager.CalculateTileCost(w, h, costPerUnit);

            //Assert
            //ExpectedException

        }

        //[TestMethod]
        //public void IsPrimeNumber_2()
        //{
        //    //Arrange
        //    int input = 2;

        //    //Act
        //    bool result = _numbersManager.IsPrimeNumber(input);

        //    //Assert
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void IsPrimeNumber_3()
        //{
        //    //Arrange
        //    int input = 3;

        //    //Act
        //    bool result = _numbersManager.IsPrimeNumber(input);

        //    //Assert
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void IsPrimeNumber_4()
        //{
        //    //Arrange
        //    int input = 4;

        //    //Act
        //    bool result = _numbersManager.IsPrimeNumber(input);

        //    //Assert
        //    Assert.AreEqual(false, result);
        //}
    }
}
