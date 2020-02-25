using System;
using System.Linq;

namespace practice
{
    public class practice 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("XIX"));
            Console.Read(); 
        }

        
        public static int Solution(string roman)
            {
                int result = 0;
            char[] charArr; 
            charArr = roman.ToCharArray(); 
            foreach (char x in charArr)
            {
            if(x == 'I')
            {
                result += 1;
            }
            
            else if(x == 'V')
            {
                result += 5;
            }
            
            else if(x == 'X')
            {
                result += 10;
            }
            
            else if(x == 'L')
            {
                result += 50;
            }
            
            else if(x == 'C')
            {
                result += 100;
            }
            
            else if(x == 'D')
            {
                result += 500;
            }
            
            else if(x == 'M')
            {
                result += 1000;
            }
            else 
            {
                result += 0; 
            }
            
            }
            return result; 
            }

    }
}
