using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*String Compression: Implement a method to perform basic string compression using the counts of repeated characters. For example, the string aabcccccaaa would become a2b1c5a3. If the "compressed" string wuld not become smaller than the original string, your method should return the original string. You can assume the string has only uppercase and lowercase letters (a-z)
     */
    class Array_StringCompression
    {
        public static void DoTest(string a)
        {
            Console.Write("Comparess string {0} to ", a);
            string ret = StringCompression(a);
            Console.WriteLine(ret);
        }
        public static string StringCompression(string a)
        {
            int countConsec=0;
            StringBuilder compressed = new StringBuilder();
            for (int i = 0; i < a.Length; i++)
            {
                countConsec++;

                if (i+1 >=a.Length || a[i] !=a[i+1])
                {
                    compressed.Append(a[i]);
                    compressed.Append(countConsec);
                    countConsec = 0;
                }
            }
            string retVal = compressed.Length < a.Length ? compressed.ToString() : a;
            return retVal;
        }
    }
}
