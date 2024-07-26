using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int sum = int.Parse(s[1]);
            int[,] dp = new int[n, sum + 1];
            int[] kashi = new int[n];

            for(int i = 0; i < n; i ++)
            {
                kashi[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < sum + 1; i++)
            {
                if((int)Math.Sqrt(i) == Math.Sqrt(i))
                {
                    dp[0, i] = (int)Math.Pow(Math.Abs(kashi[0] - Math.Sqrt(i)), 2);
                }
                else
                    dp[0, i] = 999999; 
            }
            for(int i = 1; i < n; i ++)
            {
                for(int j = 0; j < sum + 1; j ++)
                {
                    dp[i, j] = 999999;
                    for(int p = 0; p * p <= j; p++)
                    {
                        dp[i, j] = Math.Min(dp[i, j], dp[i - 1, j - (p * p)] + (int)Math.Pow(Math.Abs(kashi[i] - p), 2));
                    }
                }
            }
            if (dp[n - 1, sum] == 999999)
                Console.WriteLine(-1);
            else
            Console.WriteLine(dp[n - 1, sum]);
        }
    }
}
