using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*URLify: Write a method to replace all spaces in a string with '%20'. You may asume that the string has sufficient space at the end to hold the aditional characters, and that you are given the "true" length of the string.
     * example: input is "Mr John Smith    ", 13 output is "Mr%20John%20Smith"
     * */
    class Array_Urlify
    {
        public static void DoTest(string s, int trueLength)
        {
            Console.WriteLine("Change string {0}", s);
            string newString = URLify_lessSpace(s, trueLength);
            Console.WriteLine("The converted string is {0}", newString);
        }
        public static string URLify(string s, int trueLen)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;

            char[] sTr= s.ToCharArray();
            int countSpace = 0;

            for (int i=0; i<trueLen; i++)
            {
                if (sTr[i] == ' ')
                    countSpace++;
            }

            int newStrLength = trueLen + 2 * countSpace;
            char[] newStr = new char[newStrLength];
            for (int i = newStrLength-1, j=trueLen-1; i >= 0; i--, j--)
            {
                if (sTr[j] != ' ')
                    newStr[i] = sTr[j];
                else
                {
                    newStr[i] = '0';
                    newStr[--i] = '2';
                    newStr[--i] = '%';
                }
            }
            return new string(newStr);
        }

        public static string URLify_lessSpace(string s, int trueLen)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;

            char[] sTr = s.ToCharArray();
            int countSpace = 0;

            for (int i = 0; i < trueLen; i++)
            {
                if (sTr[i] == ' ')
                    countSpace++;
            }

            int newStrLength = trueLen + 2 * countSpace;
            if (trueLen < s.Length) sTr[trueLen] = '\0';
            for (int i = newStrLength - 1, j = trueLen - 1; i >= 0; i--, j--)
            {
                if (sTr[j] != ' ')
                    sTr[i] = sTr[j];
                else
                {
                    sTr[i] = '0';
                    sTr[--i] = '2';
                    sTr[--i] = '%';
                }
            }
            return new string(sTr);
        }
    }
}
