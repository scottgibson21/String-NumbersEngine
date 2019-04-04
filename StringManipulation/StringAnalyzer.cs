using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulation
{
    public class StringAnalyzer
    {
        public static void TestMethod()
        {
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(2);

            myList.RemoveAll(x => x == 2);
        }
    }
}
