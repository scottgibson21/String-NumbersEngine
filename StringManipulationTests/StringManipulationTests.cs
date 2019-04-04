using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulation;
using System.Collections.Generic;
using System.Linq;

namespace StringManipulationTests
{
    [TestClass]
    public class StringManipulationTests
    {

        [TestMethod]
        public void ConverToUppercaseTest_LowerCaseOnly()
        {
            //Arrange
            string inputString = "abcde";

            //Act
            string upperCasedString = StringManipulator.ConvertToUppercase(inputString);

            //Assert
            Assert.AreEqual("ABCDE", upperCasedString);
        }

        [TestMethod]
        public void ConverToUppercaseTest_MixeUpperLowerCase()
        {
            //Arrange
            string inputString = "aBCDe";

            //Act
            string upperCasedString = StringManipulator.ConvertToUppercase(inputString);

            //Assert
            Assert.AreEqual("ABCDE", upperCasedString);
        }

        [TestMethod]
        public void ConverToUppercaseTest_MixeUpperLowerCaseWithSpecialCharacters()
        {
            //Arrange
            string inputString = "aBCDe!!";

            //Act
            string upperCasedString = StringManipulator.ConvertToUppercase(inputString);

            //Assert
            Assert.AreEqual("ABCDE!!", upperCasedString);
        }

        [TestMethod]
        public void ConverToUppercaseTest_EmptyString()
        {
            //Arrange
            string inputString = "";

            //Act
            string upperCasedString = StringManipulator.ConvertToUppercase(inputString);

            //Assert
            Assert.AreEqual("", upperCasedString);
        }

        [TestMethod]
        public void ReverseCharactersTest_LettersOnly()
        {
            //Arrange
            string inputString = "abcde";

            //Act
            string reversedString = StringManipulator.ReverseCharacters(inputString);

            //Assert
            Assert.AreEqual("edcba", reversedString);
        }

        [TestMethod]
        public void ReverseCharactersTest_LettersWithSpaces()
        {
            //Arrange
            string inputString = "abcde fg";

            //Act
            string reversedString = StringManipulator.ReverseCharacters(inputString);

            //Assert
            Assert.AreEqual("gf edcba", reversedString);
        }

        [TestMethod]
        public void ReverseCharactersTest_NumbersOnly()
        {
            //Arrange
            string inputString = "1234";

            //Act
            string reversedString = StringManipulator.ReverseCharacters(inputString);

            //Assert
            Assert.AreEqual("4321", reversedString);
        }

        [TestMethod]
        public void ConvertToBinary_LettersOnly()
        {
            //Arrange
            string inputString = "abc";

            //Act
            string binaryString = StringManipulator.ConvertToBinary(inputString);

            //Assert
            Assert.AreEqual("01100001 01100010 01100011 ", binaryString);
        }

        [TestMethod]
        public void ConvertToBinary_SpecialCharacters()
        {
            //Arrange
            string inputString = "!#";

            //Act
            string binaryString = StringManipulator.ConvertToBinary(inputString);

            //Assert
            Assert.AreEqual("00100001 00100011 ", binaryString);
        }

        [TestMethod]
        public void FetchDuplicateCharacters_NoDuplicateChars()
        {
            //Arrange
            string inputString = "abcde";
            string expectedOutput = "NO DUPLICATE CHARACTERS";

            //Act
            string duplicateCharList = StringManipulator.FetchDuplicateCharacters(inputString);

            //Assert
            Assert.AreEqual(expectedOutput, duplicateCharList);
        }

        [TestMethod]
        public void FetchDuplicateCharacters_DuplicateChars()
        {
            //Arrange
            string inputString = "abcdeabc";
            string expectedOutput = "a,b,c";
            //Act
            string duplicateCharList = StringManipulator.FetchDuplicateCharacters(inputString);

            //Assert
            Assert.AreEqual(expectedOutput, duplicateCharList);
        }

        [TestMethod]
        public void FetchDuplicateCharacters_NullInput()
        {
            //Arrange
            string inputString = null;

            //Act
            string duplicateCharList = StringManipulator.FetchDuplicateCharacters(inputString);

            //Assert
            Assert.AreEqual(null, duplicateCharList);
        }

        [TestMethod]
        public void FindFirstNonRepeatedChar_NullInput()
        {
            //Arrange
            string inputString = null;

            //Act
            string duplicateCharList = StringManipulator.FindFirstNonRepeatedChar(inputString);

            //Assert
            Assert.AreEqual(null, duplicateCharList);
        }

        [TestMethod]
        public void FindFirstNonRepeatedChar_NoDuplicateChars()
        {
            //Arrange
            string inputString = "abcde";

            //Act
            string duplicateCharList = StringManipulator.FindFirstNonRepeatedChar(inputString);

            //Assert
            Assert.AreEqual("NO REPEATED CHARACTERS", duplicateCharList);
        }

        [TestMethod]
        public void FindFirstNonRepeatedChar_WithDuplicateChars()
        {
            //Arrange
            string inputString = "abcdeabc";

            //Act
            string duplicateCharList = StringManipulator.FindFirstNonRepeatedChar(inputString);

            //Assert
            Assert.AreEqual("a", duplicateCharList);
        }

        [TestMethod]
        public void CheckForAnagram_WithNullStr1()
        {
            //Arrange
            string inputString1 = null;
            string inputString2 = "abc";

            //Act
            string isAnagram = StringManipulator.checkForAnagram(inputString1, inputString2);

            //Assert
            Assert.AreEqual(null, isAnagram);
        }

        [TestMethod]
        public void CheckForAnagram_ValidAnagram()
        {
            //Arrange
            string inputString1 = "cba";
            string inputString2 = "abc";

            //Act
            string isAnagram = StringManipulator.checkForAnagram(inputString1, inputString2);

            //Assert
            Assert.AreEqual("YES", isAnagram);
        }

        [TestMethod]
        public void CheckForAnagram_InvalidAnagramDifLength()
        {
            //Arrange
            string inputString1 = "cbaa";
            string inputString2 = "abc";

            //Act
            string isAnagram = StringManipulator.checkForAnagram(inputString1, inputString2);

            //Assert
            Assert.AreEqual("NO", isAnagram);
        }

        [TestMethod]
        public void CheckForAnagram_InvalidAnagramSameLength()
        {
            //Arrange
            string inputString1 = "aaa";
            string inputString2 = "abc";

            //Act
            string isAnagram = StringManipulator.checkForAnagram(inputString1, inputString2);

            //Assert
            Assert.AreEqual("NO", isAnagram);
        }

        [TestMethod]
        public void IsNumbersOnly_StringWithOnlyNumbers()
        {
            //Arrange
            string inputString = "12345";

            //Act
            string isNumbersOnly = StringManipulator.IsNumbersOnly(inputString);

            //Assert
            Assert.AreEqual("YES", isNumbersOnly);
        }

        [TestMethod]
        public void IsNumbersOnly_StringWithNumbersAndLetters()
        {
            //Arrange
            string inputString = "1a2b3c";

            //Act
            string isNumbersOnly = StringManipulator.IsNumbersOnly(inputString);

            //Assert
            Assert.AreEqual("NO", isNumbersOnly);
        }

        [TestMethod]
        public void IsNumbersOnly_StringWithNumbersAndSpecialChars()
        {
            //Arrange
            string inputString = "abc!!!";

            //Act
            string isNumbersOnly = StringManipulator.IsNumbersOnly(inputString);

            //Assert
            Assert.AreEqual("NO", isNumbersOnly);
        }

        [TestMethod]
        public void IsNumbersOnly_NullInput()
        {
            //Arrange
            string inputString = "";

            //Act
            string isNumbersOnly = StringManipulator.IsNumbersOnly(inputString);

            //Assert
            Assert.AreEqual(null, isNumbersOnly);
        }

        [TestMethod]
        public void CountConsonantsAndVowels_ConsonantsOnly()
        {
            //Arrange
            string inputString = "bcdfg";

            //Act
            var consonantAndVowelCount = StringManipulator.CountConsonantsAndVowels(inputString);

            //Assert
            Assert.AreEqual(consonantAndVowelCount.Item1, 0);
            Assert.AreEqual(consonantAndVowelCount.Item2, 5);
        }

        [TestMethod]
        public void CountConsonantsAndVowels_RepeatingVowelsOnly()
        {
            //Arrange
            string inputString = "aaaaa";

            //Act
            var consonantAndVowelCount = StringManipulator.CountConsonantsAndVowels(inputString);

            //Assert
            Assert.AreEqual(consonantAndVowelCount.Item1, 5);
            Assert.AreEqual(consonantAndVowelCount.Item2, 0);
        }

        [TestMethod]
        public void CountConsonantsAndVowels_VowelsOnly()
        {
            //Arrange
            string inputString = "aeiou";

            //Act
            var consonantAndVowelCount = StringManipulator.CountConsonantsAndVowels(inputString);

            //Assert
            Assert.AreEqual(consonantAndVowelCount.Item1, 5);
            Assert.AreEqual(consonantAndVowelCount.Item2, 0);
        }

        [TestMethod]
        public void CountConsonantsAndVowels_NullInput()
        {
            //Arrange
            string inputString = null;

            //Act
            var consonantAndVowelCount = StringManipulator.CountConsonantsAndVowels(inputString);

            //Assert
            Assert.AreEqual(0, consonantAndVowelCount.Item1);
            Assert.AreEqual(0, consonantAndVowelCount.Item1);
        }

        [TestMethod]
        public void FetchHighestChar_NullInput()
        {
            //Arrange
            string inputString = null;

            //Act
            var highestChar = StringManipulator.FetchHighestChar(inputString);

            //Assert
            Assert.AreEqual(null, highestChar);
        }

        [TestMethod]
        public void FetchHighestChar_LowerCaseLettersOnly()
        {
            //Arrange
            string inputString = "abcdeabcd";

            //Act
            var highestChar = StringManipulator.FetchHighestChar(inputString);

            //Assert
            Assert.AreEqual("e", highestChar);
        }

        [TestMethod]
        public void FetchHighestChar_LowerCaseAndUpperCaseLettersOnly()
        {
            //Arrange
            string inputString = "abcdeABCDE";

            //Act
            var highestChar = StringManipulator.FetchHighestChar(inputString);

            //Assert
            Assert.AreEqual("e", highestChar);
        }

        [TestMethod]
        public void FetchHighestChar_LettersNumersAndSpecialChars()
        {
            //Arrange
            string inputString = "abc123!!!";

            //Act
            var highestChar = StringManipulator.FetchHighestChar(inputString);

            //Assert
            Assert.AreEqual("c", highestChar);
        }

        [TestMethod]
        public void RemoveSpecifiedChars_ValidListOfChars()
        {
            //Arrange
            List<char> listOfChars = new List<char>();
            listOfChars.Add('a');
            listOfChars.Add('b');

            string inputString = "abc123!!!";

            //Act
            string finalString = StringManipulator.RemoveSpecifiedChars(listOfChars, inputString);

            //Assert
            Assert.AreEqual("c123!!!", finalString);
        }

        [TestMethod]
        public void RemoveSpecifiedChars_null()
        {
            //Arrange
            List<char> listOfChars = new List<char>();

            string inputString = null;

            //Act
            string finalString = StringManipulator.RemoveSpecifiedChars(listOfChars, inputString);

            //Assert
            Assert.AreEqual(null, finalString);
        }

        [TestMethod]
        public void RemoveSpecifiedChars_StringDoesNotContainCharsFromList()
        {
            //Arrange
            List<char> listOfChars = new List<char>();
            listOfChars.Add('a');
            listOfChars.Add('b');
            listOfChars.Add('c');

            string inputString = "defg!!";

            //Act
            string finalString = StringManipulator.RemoveSpecifiedChars(listOfChars, inputString);

            //Assert
            Assert.AreEqual("defg!!", finalString);
        }

    }
}
