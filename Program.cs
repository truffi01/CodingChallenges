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
        public static long QueueTime(int[] customers, int n)
        {
        int[] till = new int[n];         
        for(int i=0;i<customers.Length;i++){       
            till[Array.IndexOf(till, till.Min())]+=customers[i];
        }
        return till.Max();
        }
    }
}
