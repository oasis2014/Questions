using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /// <summary>
    ///  Design an algorithm and write code to remove the duplicate characters in a string without using any additional buffer. NOTE: One or two additional variables is fine.  An extra copy of the array is not. FOLLOW UP Write the test cases for this method. 
    /// </summary>
    class Array_RemoveDuplicate
    {
        public static string removeDuplicates(string s)
        {
            char[] str = s.ToCharArray();
            if (str == null) return s;
            int len = str.Length;
            if (len < 2) return s;
            int tail = 1;
            for (int i = 1; i < len; ++i)
            {
                int j;
                for (j = 0; j < tail; ++j)
                {
                    if (str[i] == str[j]) break;
                }
                if (j == tail)
                {
                    str[tail] = str[i];
                    ++tail;
                }
            }
            return new string(str, 0, tail);
        }
        public static string RemoveDuplicate(string s)
        {
            char[] sarr = s.ToCharArray();
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                char target = sarr[i];
                for (int j = len - 1; j > i; j--)
                {
                    if (target == sarr[j])
                    {
                        for (int n=j;n<len;n++)
                        {
                            if (n < len - 1)
                            {
                                sarr[n] = sarr[n + 1];
                            }
                        }
                        len--;
                    }
                }
            }
            string output = new string(sarr, 0, len);
            return output;
        }
    }
}
