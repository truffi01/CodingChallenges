
  // return masked string
  public static string Maskify(string cc)
  {
  char[] charrArr = cc.ToCharArray();
  
  for (int i = 0; i < charrArr.Length - 4; i++)
  {
    charrArr[i] = '#'
  }
  string result = new string(charrArr);
  return result;
  }

  Console.Writeline(Maskify("1234567"))

