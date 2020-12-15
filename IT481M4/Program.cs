using System;

namespace IT481M4
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 10000;
            int[] small = new int[10];
            int[] medium = new int[100];
            int[] large = new int[1000];

            // load the arrays with random numbers. 
            Random randomSmall = new Random();
            for (int i = 0; i < small.Length; i++)
            {
                small[i] = randomSmall.Next(min, max);
            }

            Random randomMedium = new Random();
            for (int i = 0; i < medium.Length; i++)
            {
                medium[i] = randomMedium.Next(min, max);
            }

            Random randomLarge = new Random();
            for (int i = 0; i < large.Length; i++)
            {
                large[i] = randomLarge.Next(min, max);
            }


            for (int i = 0; i < small.Length; i++)
            {
                Console.WriteLine(small[i]);
            }

        }
    }
}
