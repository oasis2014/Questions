using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*Is unique: implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structure?*/

    class Array_AlluniqueCharacters
    {
        public static void DoTest(string s)
        {
            Console.WriteLine("The string is: {0,3}", s);
            bool isUnique = IsUnique(s);
            Console.WriteLine("Does the string have all unique characters? {0}", isUnique);
        }
        /// <summary>
        /// Check if a string has all unique characters using o(n^2)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsUnique(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            int tail = 1;
            Char [] strArray = s.ToCharArray();

            for (int i = 1; i < strArray.Length; i++)
            {
                int j = 1;
                for (j = 0; j < tail; j++)
                {
                    if (strArray[i] == strArray[j])
                        return false;
                }
                if (j == tail)
                {
                    tail++;
                    strArray[j] = strArray[i];
                }
            }
            return true;
        }

    }
}
