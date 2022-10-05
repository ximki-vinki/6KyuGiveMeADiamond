using System;
using System.Text;

namespace _6KyuGiveMeADiamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }
    public class Diamond
    {
        public static string print(int n)
        {
            if (n < 0 || n % 2 == 0) return null;
            StringBuilder diamond=new StringBuilder();
            int centerDiamanon = n / 2 + 1;
            int starsCount = 1;

            for (int x = 1; x < centerDiamanon; x++)
            {
                diamond.Append( new string(' ', centerDiamanon - x) + new string('*', starsCount) + "\n");
                starsCount += 2;
            }

            diamond.Append(new string('*', n) + "\n");

            for (int x = centerDiamanon - 1; x > 0; x--)
            {
                starsCount -= 2;
                diamond.Append( new string(' ', centerDiamanon - x) + new string('*', starsCount) + "\n");
            }
            return diamond.ToString();
        }
    }
}
