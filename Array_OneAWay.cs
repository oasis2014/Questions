using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*One Away: There are three types of edits that can be performed on strings: Insert a character, remove a character, or replace a character. Given two strings, write a function to check if they are one edit(or zero edits) away
     */ 
    class Array_OneAWay
    {
        public static void DoTest(string a, string b)
        {
            Console.Write("Are two strings {0} and {1} One Edit? ", a, b);
            bool oneEdit = CheckOneAway(a, b);
            Console.WriteLine(oneEdit);
        }

        /// <summary>
        /// Check if a is one away from b
        /// </summary>
        /// <param name="a">after edit</param>
        /// <param name="b">before edit</param>
        /// <returns></returns>
        public static bool CheckOneAway(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b)) return false;

            if (a.Length == b.Length)
                return OneEditReplace(a, b);
            else if (a.Length > b.Length)
            {
                return OneEditInsert(a, b);
            }
            else if (b.Length > a.Length)
                return OneEditInsert(b, a);
            return false;
        }

        private static bool OneEditReplace(string a, string b)
        {
            bool OneEdit=false;
            char[] astr = a.ToCharArray();
            char[] bstr = b.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    if (OneEdit)
                        return false;
                    else
                        OneEdit = true;
                }
            }
            return OneEdit;
        }

        private static bool OneEditInsert(string a, string b)
        {
            int index1=0, index2=0;
            char[] astr = a.ToCharArray();
            char[] bstr = b.ToCharArray();

            if (a.Length - b.Length != 1) return false;
            while (index1 < astr.Length && index2 < bstr.Length)
            {
                if (astr[index1] != bstr[index2])
                {
                    if (index1 != index2)
                        return false;
                    else
                        index1++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }
    }
}
