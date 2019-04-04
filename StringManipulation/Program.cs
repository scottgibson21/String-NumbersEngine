using System;
using System.Collections.Generic;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {    
            bool cont = true;

            while (cont)
            {
                StringAnalyzer.TestMethod();

                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("\n1. Manipulate String");
                Console.WriteLine("2. Compare Strings");
                Console.Write("\nENTER SELECTION: ");
                string selection = Console.ReadLine();

                if (selection == "1")
                {
                    Console.WriteLine("\n--STRING MANIPULATION--\n");

                    Console.Write("String to Maniuplate: ");
                    string inputString1 = Console.ReadLine();

                    string reversedString = StringManipulator.ReverseCharacters(inputString1);
                    string toUpperString = StringManipulator.ConvertToUppercase(inputString1);
                    string toBinaryString = StringManipulator.ConvertToBinary(inputString1);
                    string duplicateChars = StringManipulator.FetchDuplicateCharacters(inputString1);

                    //Console.WriteLine("\nINPUT: " + inputString);
                    Console.WriteLine("\nREVERSE: " + reversedString);
                    Console.WriteLine("UPPERCASE: " + toUpperString);
                    Console.WriteLine("BINARY: " + toBinaryString);
                    Console.WriteLine("DUPLICATE CHARS: " + duplicateChars);
                }
                else
                {
                    Console.WriteLine("\n--STRING COMPARISONS--\n");

                    Console.Write("String 1: ");
                    string inputCompareString1 = Console.ReadLine();
                    Console.Write("String 2: ");
                    string inputCompareString2 = Console.ReadLine();

                    string isAnagram = StringManipulator.checkForAnagram(inputCompareString1, inputCompareString2);

                    Console.WriteLine("ANAGRAM: " + isAnagram);

                }

                Console.Write("\nWould you like to continue (Y/N)? ");

                if (Console.ReadLine() == "Y")
                {
                    cont = true;
                } else
                {
                    cont = false;
                }
            }

        }
    }
}
