using System;
public class Kata
{
  public static long NextSmaller(long n)
  {
     char[] DigitArray = n.ToString().ToCharArray();
     
     var ints = DigitArray.Select(x => int.Parse(x.ToString()));
     


  }
}

nextSmaller(21) == 12
nextSmaller(531) == 513
nextSmaller(2071) == 2017
