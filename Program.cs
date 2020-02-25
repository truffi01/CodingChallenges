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

        public static int DontGiveMeFive(int start, int end)
        {
            return Enumerable.Range(start, end-start+1).Count(x => !x.ToString().Contains("5"));
        }
    }
}
