  using System;
  public class Sum
  {
     public int GetSum(int a, int b)
     {
       int Sum = 0;

       for (int i = a; i <= b; i++)
       {
           Sum += i; 
       }

        
        return Sum; 

     }
  }