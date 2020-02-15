public static class Kata
{
  public static string ReverseWords(string str)
  {
        List<string> sl= new List<string>();// List to hold the reversed words
        
        string[] words = str.Split(' ');// convert str to string array
        
        foreach(string s in words)  // loop through string array
        {
          char[] scharr= s.ToCharArray();//convert string to char array
          Array.Reverse(scharr);//reverse char array
          
          string sreverse= new string (scharr);// create string with char array
          
          sl.Add(sreverse);//add string to the list
        }
        
        return string.Join(" ", sl.ToArray());//Return the list as a string
  }
}