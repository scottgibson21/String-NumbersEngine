using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringManipulation
{
    public class StringManipulator
    {
        public static string ReverseCharacters(string inputString)
        {
            if (inputString == null)
            {
                return null;
            }

            //Convert string to array of characters, and create empty array to store reveresed characters
            char[] charArray = inputString.ToCharArray();
            int arrayLength = charArray.Length;
            char[] reversedCharArray = new char[arrayLength];

            //Iterate through the array of characters and add in reverse order to empty reversedCharArray
            for (int i = 0; i < arrayLength; i++)
            {
                reversedCharArray[i] = charArray[(arrayLength - 1) - i];
            }

            //Convert the reversed list of chars to string
            string reversedString = new string(reversedCharArray);
            return reversedString;
        }

        public static string ConvertToUppercase(string inputString)
        {
            if (inputString == null)
            {
                return null;
            }

            //Convert string to array of chars
            char[] charArray = inputString.ToCharArray();
            int charArrayLen = charArray.Length;

            //Iterate through the char array, if the character is lowercase (ascii value 67-122), convert to uppercase
            for (int i = 0; i < charArrayLen; i++)
            {
                if (charArray[i] >= 97 && charArray[i] <= 122)
                {
                    charArray[i] -= (char)32;
                }
            }

            //convert array of chars back to string
            string str = new string(charArray);
            return str;
        }

        public static string ConvertToBinary(string inputString)
        {
            if (inputString == null)
            {
                return null;
            }

            //Convert inputString to an array of chars
            char[] charArray = inputString.ToCharArray();
            string resultString = "";

            //Iterate through char array, convert each char to binary value in string format.  Left is padded to 8 spaces with 0's to display full byte
            foreach (char c in charArray)
            {
                resultString += Convert.ToString((int)c, 2).PadLeft(8, '0') + " ";
            }
            
            return resultString;
        }

        public static string FetchDuplicateCharacters(string inputString)
        {

            if (inputString == null)
            {
                return null;
            }

            //List of chars used for tracking duplicates
            List<char> listOfDuplicateChars = new List<char>();

            int strLen = inputString.Length;

            //Iterate through each character and compare with following characters, don't check last character
            for (int i = 0; i < strLen - 1; i++)
            {

                //If the character being checked is already in the list of duplicates, skip this iteration
                if (listOfDuplicateChars.Contains(inputString[i]))
                {
                    continue;
                }

                for(int j = i + 1; j < strLen; j++)
                {
                    if (inputString[i] == inputString[j])
                    {
                            listOfDuplicateChars.Add(inputString[i]);
                            break;
                    }
                }
            }

            string duplicateCharString = String.Join(",", listOfDuplicateChars);
           
            if (duplicateCharString != "")
            {
                return duplicateCharString;
            }
            else
            {
                return "NO DUPLICATE CHARACTERS";
            }

        }

        public static string checkForAnagram(string str1, string str2)
        {
            //If either string is null return null
            if (str1 == null || str2 == null)
            {
                return null;
            }

            //If the strings are the same length return since strings can't be anagram
            if (str1.Length != str2.Length)
            {
                return "NO";
            }

            var strLen = str1.Length;
            bool isAnagram = true;

            //Iterate through each position in strings, comparing first character of Str1 to 
            //last character of Str2, then second character of Str1 to second to last character
            //of Str2, etc
            for (int i = 0; i < strLen; i++)
            {
                if (str1[i] != str2[(strLen - 1) - i])
                {
                    isAnagram = false;
                    break;
                }
            }

            //Return result as a string
            if (isAnagram)
            {
                return "YES";
            } else
            {
                return "NO";
            }
        }

        public static string FindFirstNonRepeatedChar(string inputString)
        { 
            if (String.IsNullOrEmpty(inputString))
            {
                return null;
            }

            //Default first repeated char holder in case no repeated chars are found
            string firstRepeatedChar = "NO REPEATED CHARACTERS";
            int strLen = inputString.Length;

            //Iterate thought each position in the string, nested loop compares all following
            //positions and returns character as string if its found
            for (int i = 0; i < strLen - 1; i++)
            {
                for (int j = i + 1; j < strLen - 1; j++)
                {
                    if (inputString[i] == inputString[j])
                    {
                        firstRepeatedChar = inputString[i].ToString();
                        return firstRepeatedChar;
                    }
                }
            }

            //Return default value if no duplicates are found
            return firstRepeatedChar;
        }

        public static string IsNumbersOnly(string inputString)
        {

            if (String.IsNullOrEmpty(inputString))
            {
                return null;
            }


            bool nonNumFound = false;
            int strLen = inputString.Length;

            //Iterate through each character in the string and break if a non number is found
            for (int i = 0; i < strLen; i++)
            {
                if (!Char.IsDigit(inputString[i]))
                {
                    nonNumFound = true;
                    break;
                }
            }

            //Return result as string
            if (nonNumFound)
            {
                return "NO";
            }
            else
            {
                return "YES";
            }
        }

        public static (int, int) CountConsonantsAndVowels(string inputString)
        {

            if (String.IsNullOrWhiteSpace(inputString))
            {
                return (0, 0);
            }

            int vowelCount = 0;
            int consonantCount = 0;
            int strLen = inputString.Length;
            string vowelList = "aeiouAEIOU";
            string consonantList = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWZYZ";

            for (int i = 0; i < strLen; i++)
            {
                if (vowelList.IndexOf(inputString[i]) >= 0)
                {
                    vowelCount++;
                }
                else if (consonantList.IndexOf(inputString[i]) >= 0)
                {
                    consonantCount++;
                }
                
            }

            return (vowelCount, consonantCount);
        }

        public static string FetchHighestChar(string inputString)
        {
            if (String.IsNullOrWhiteSpace(inputString))
            {
                return null;
            }

            char highestChar = inputString[0];
            int strLen = inputString.Length;

            for (int i = 0; i < strLen; i++)
            {
                if (inputString[i] > highestChar)
                {
                    highestChar = inputString[i];
                }
            }

            return highestChar.ToString();
            
        }

        public static string RemoveSpecifiedChars(List<char> listOfCharsToRemove, string inputString)
        {
            if (String.IsNullOrWhiteSpace(inputString))
            {
                return null;
            }

            var charList = new List<char>();
            charList.AddRange(inputString);
        

            charList.RemoveAll(x => listOfCharsToRemove.Contains(x));

            return String.Join("", charList);
        }

    }
}
