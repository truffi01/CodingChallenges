public class Dubstep
    {
        public static string SongDecoder(string input)
        {
          // Replace each "WUB" with space. Split into words. Toss empty words. Recombine with space in between.
          return input.Replace("WUB", " ").Split(' ').Where(w => w.Length > 0).Aggregate((a, b) => a + " " + b);
        }
    }
