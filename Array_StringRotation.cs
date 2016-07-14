using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*String Rotation: Assume you have a method isSubstring which checks if one word is substring of another. Given two strings, s1 and s2, write code to check if s2 is rotation of s1 using only one call to isSubstring(e.g, "waterbottle" is rotation of "erbottlewat")
     */
    class Array_StringRotation
    {
        public static bool IsStringRotation1(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2)) return false;

            char[] s1array=s1.ToCharArray();
            char[] s2array=s2.ToCharArray();
            List<char> temp= new List<char>();

            int i=0, j=0;
            for (i = 0, j=0; i < s1array.Length; i++, j++)
            {
                if (s1array[i] != s2array[j])
                {
                    temp.Add(s1array[i]);
                    i++;
                }
            }
            if (s2.Substring(j) == temp.ToString())
                return true;
            else
                return false;
        }

        public static bool IsStringRotation(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2)) return false;
            int len1 =s1.Length, len2= s2.Length; 
            if (len1!=len2 || len1==0 ||len2==0 ) return false;

            string s = s1 + s2;
            if (IsSubstring(s, s2)) return true;
            return false;
        }

        /// <summary>
        /// check if s2 is substring of s1
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        private static bool IsSubstring(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2)) return false;
            return s1.Contains(s2);
        }
    }
}
