using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
       return integers.Count(a=>a%2==1)>1?integers.Single(a=>a%2==0):integers.Single(a=>a%2==1);

  }
}