using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*Check Permutation: given two strings, write a method to decide if one is a permutation of the other*/
    class Array_CheckPermutation
    {
        public static void DoTest(string a, string b)
        {
            Console.WriteLine("Two strings are {0,3}, {1,3}", a, b);
            bool isPerm = CheckPermutation(a, b);
            Console.WriteLine("They are Permuation:{0,3}", isPerm);
        }
        public static bool CheckPermutation(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b)) return false;
            if (a.Length != b.Length) return false;

            int[] characters = new int[256];
            char [] aStr=a.ToCharArray();
            char [] bStr = b.ToCharArray();
            for (int i = 0; i < aStr.Length; i++)
            {
                characters[aStr[i]]++;
            }

            for (int i = 0; i < bStr.Length; i++)
            {
                if (characters[bStr[i]] == 0)
                    return false;
            }
            return true;
        }
    }
}
