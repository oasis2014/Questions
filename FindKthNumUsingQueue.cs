using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class FindKthNumUsingQueue
    {
        public static int FindKthNumber(int k)
        {
            int [] numbers = new int[k];
            numbers[0]=1;
            Queue<int> q3=new Queue<int>();
            Queue<int> q5=new Queue<int>();
            Queue<int> q7= new Queue<int>();

            for (int i = 1; i < k; i++)
            {
                q3.Enqueue(numbers[i - 1] * 3);
                q5.Enqueue(numbers[i - 1] * 5); 
                q7.Enqueue(numbers[i - 1] * 7);

                if (q3.First() < q5.First() && q3.First() < q7.First())
                {
                    numbers[i] = q3.Dequeue();
                }
                else if (q5.First() < q3.First() && q5.First() < q7.First())
                {
                    numbers[i] = q5.Dequeue();
                }
                else if (q7.First() < q3.First() && q7.First() < q5.First())
                {
                    numbers[i] = q7.Dequeue();
                }
                else if (q3.First() == q5.First())
                {
                    numbers[i] = q3.Dequeue();
                    q5.Dequeue();
                }
                else if (q3.First() == q7.First())
                {
                    numbers[i] = q3.Dequeue();
                    q7.Dequeue();
                }
                else if (q5.First() == q7.First())
                {
                    numbers[i] = q5.Dequeue();
                    q7.Dequeue();
                }
                Console.WriteLine(string.Format("the {0}th number is {1}", i, numbers[i]));
            }
            Console.WriteLine("the kth number is:"+numbers[k-1]);
            return numbers[k - 1];
        }
    }
}
