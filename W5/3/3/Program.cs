using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            long n = int.Parse(s[0]);
            int k = int.Parse(s[1]);

            long ans = 1;
            long hold = 0;
            for (int i = 2; i <= k; i++)
            {
                if (i == 2)
                {
                    hold = (n * (n - 1)) / 2;
                }
                else if (i == 3)
                {
                    hold = ((n * (n - 1) * (n - 2)) / 6) * 2;
                }
                else if (i == 4)
                {
                    hold = ((n * (n - 1) * (n - 2) * (n - 3)) / 24) * 9;
                }
                ans += hold;
            }
            Console.WriteLine(ans);
        }
    }
}
