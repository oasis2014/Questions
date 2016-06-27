using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /// <summary>
    /// Example: Given two numbers m and n, write a method to return the first number r that is
    /// divisible by both (e.g., the least common multiple).
    /// </summary>
    class PrimeNumbers
    {
        public static void FindLCM(int m, int n)
        {
            int lcm = 1;
            // Given a prime number p, if it is in m or n, lcm=lcm*p
            int max = m >=n ? m : n;
            List<int> primes= GetPrimeNumbers(max);
            foreach (int p in primes)
            {

                while (m % p == 0 || n % p == 0)
                {
                    lcm = lcm * p;
                    m = m% p ==0 ? m / p : m;
                    n = n%p ==0 ? n / p : n;
                }
            }
            Console.WriteLine("The Least multiplication numer: " + lcm);
            Console.ReadLine();
        }

        public static List<int> GetPrimeNumbers(int max)
        {
            int nextPrime = 3;
            List<int> primes = new List<int>();
            if (max >= 2)
            {
                primes.Add(2);
            }
            if (max >= 3)
            {
                primes.Add(3);
            }

            while (nextPrime < max)
            {
                nextPrime += 2;
                if (nextPrime > max) break;
                if (primes.Where(prime => nextPrime % prime == 0).Count() == 0)
                {
                    primes.Add(nextPrime);
                }
            }
            return primes;
        }
    }
}
