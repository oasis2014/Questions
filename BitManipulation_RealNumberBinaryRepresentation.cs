using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*
     * Given a (decimal - e.g. 3.72) number that is passed in as a string, print the binary representation. If the number can not be represented accurately in binary, print “ERROR” 
     * */
    class BitManipulation_RealNumberBinaryRepresentation
    {
        public static void DoTest(double num)
        {
            Console.WriteLine("The decimal number is {0,3}", num);
            string rep = GetBinRepresentation(num);
            Console.WriteLine("its binary representation is {0,10}", rep);
        }
        public static string GetBinRepresentation(double num)
        {
            if (num >= 1 || num <= 0) return "ERROR";
            StringBuilder binary = new StringBuilder(".");

            while (num > 0)
            {
                if (binary.Length >= 32)
                {
                    return "ERROR";
                }
                double r = 2 * num;
                if (r >= 1)
                {
                    binary.Append("1");
                    num = r - 1;
                }
                else
                {
                    binary.Append("0");
                }
            }
            return binary.ToString();

        }
    }
}
