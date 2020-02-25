using System;
using System.Linq;
using Systems.Collections.Generic; 

namespace practice
{
    public class practice 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(QueueTime([2,3,4], 2));
            Console.Read(); 
        }

        public static long QueueTime(int[] customers, int n)
        {
             if (n >= customers.Length)
            {
               
                return customers.Max();
            }

            if (n < customers.Length && n >1)
            {
                int Timey = 0; 
                var Result = Array.Sort(customers);
                for (int x = 0; x < Result.Length; x + 2)
                {
                    Timey += Result[x];
                    Timey += Result[x+1];
                }
                return Timey; 
            }

            if (n == 1)
            {
                return customers.Sum();
            }
            return 0;
        }
    }
}
