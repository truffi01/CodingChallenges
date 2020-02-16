using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
    int even = 0;
    int odd = 0; 
    
    foreach(int var in integers)
    {
      if (var % 2 == 0)
      {
        even++;
      }
      if (var % 2 == 0)
      {
        odd++; 
      }
      
      if (even>1 && odd == 1)
      {
        return var;
      }
      if (odd>1 && even == 1)
      {
        return var;
      }
      
    }
  }