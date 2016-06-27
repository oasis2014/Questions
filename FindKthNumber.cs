using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class FindKthNumber
    {
        public static void FindKth(int k)
        {
            List<int> theList = new List<int>();
            theList.Add(1);
            while (theList.Count < k)
            {
                theList.Add(FindNextNumber(theList));
            }
            Console.WriteLine(string.Format("the {0}th number is {1} ",theList.Count, theList[theList.Count-1]));
            Console.ReadLine();
        }

        public static int FindNextNumber(List<int> list)
        {
            int currCount = list.Count;
            int prev = list[currCount - 1];
            int next = 0;
            for (int i = 0; i < currCount; i++)
            {
                if (list[i] * 3 > prev || list[i] * 5 > prev || list[i] * 7 > prev)
                {
                    List<int> temp = new List<int>();
                    if (list[i] * 3 > prev) temp.Add(list[i] * 3);
                    if (list[i] * 5 > prev) temp.Add(list[i] * 5);
                    if (list[i] * 7 > prev) temp.Add(list[i] * 7);
                    temp.Sort();
                    next = temp[0];
                    Console.WriteLine(string.Format("the {0}th is  {1}", currCount, next));
                    break;
                }
            }
            return next;
        }
    }
}
