using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*Palindrom Permutation:Given a string, write a function to check if it is a permutation of a palindrome.*/
    class Array_CheckPalindrom
    {
        public static void DoTest(string s)
        {
            Console.Write("Is string {0} a palindrom?", s);
            bool yes=CheckPalindrom(s);
            Console.WriteLine(yes);
        }
        public static bool CheckPalindrom(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;

            int CountOdd = 0;
            int[] sMap = new int[256];
            char[] sTr = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                int cValue=GetCharValue(sTr[i]);
                if (cValue != -1)
                {

                    sMap[cValue]++;
                    if (sMap[cValue] % 2 == 1)
                        CountOdd++;
                    else
                        CountOdd--;
                }
            }
            return CountOdd<=1;
        }

        private static int GetCharValue(char c)
        {
            if (c >= 97 && c <= 122)
                return (int)c;
            else if (c >= 65 && c <= 90)
                return (int)c + 32;
            else
                return -1;
        }
    }
}
