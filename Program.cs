using System;
using System.Collections.Generic; 

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
    
        static int NbDig(int n, int d) 
        {
            int counter = 0;
            
            for (int i = 0; i <= n; i++)
            foreach(char c in (i * i).ToString())
                if (c == char.Parse(d.ToString()))
                counter++;
                
            return counter;
        }

            Console.WriteLine(NbDig(4,1));
            
        }
    }
}
