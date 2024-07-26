using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] dp = new long[n + 1];
            dp[0] = 1;
            long hold = 1, N = 998244353;
            for (int i = 1; i <= n; i++)
            {
                hold *= i;
                hold %= N;
                dp[i] = (((dp[i - 1] - 1) * i) % N + hold) % N;
            }

            Console.WriteLine(dp[n]);
        }
    }
}
