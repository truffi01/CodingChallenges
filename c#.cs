
using System.Linq;
public class Kata
{
    public static string PigIt(string str)
    {
        return string.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
    }
}

