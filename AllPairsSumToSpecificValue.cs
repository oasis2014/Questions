using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*
     *  Design an algorithm to find all pairs of integers within an array which sum to a specified value
     *  */
    class AllPairsSumToSpecificValue
    {
        public static void DoTest(int[] input, int value)
        {
            Console.WriteLine("The array is:");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("{0,3}", input[i]);
            }
            Console.WriteLine();
            Console.WriteLine("the pairs sum to {0,3} are:", value);
            AllPairsSumToSpecificValue.FindPairs(input, value);
        }
        public static void FindPairs(int[] input, int value)
        {
            if (input == null) return;
            if (value == null) return;

            Dictionary<int, int> Map = new Dictionary<int, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Map.ContainsKey(value-input[i]))
                {
                    Map[value-input[i]]++;
                }
                else if (input[i] == (value - input[i]) && Map.ContainsKey(input[i]))
                {
                    Map[input[i]]++;
                }

                if (!Map.ContainsKey(input[i]) && !Map.ContainsKey(value - input[i]))
                    Map[input[i]] = 0;
            }

            foreach (var item in Map)
            {
                if (item.Value !=0)
                {
                    Console.WriteLine("{0,3} + {1,3} = {2,3}", item.Key, value-item.Key, value);
                }
            }
        }
    }
}
