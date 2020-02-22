using System;
public class Kata
{
  public static long FindNextSquare(long num)
  {
    double a=Math.Sqrt(num);
    return (a==(int)a)?(long)Math.Pow(a+1,2) : -1;
   
  }
}
