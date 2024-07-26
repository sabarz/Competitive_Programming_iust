using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = new long[n];
            string[] s = Console.ReadLine().Split(' ');
            for (int p = 0; p < n; p++)
            {
                a[p] = long.Parse(s[p]);
            }
            long ans = a[0];
            long[] dp = new long[n];
            dp[0] = a[0];
            for (int i = 1; i < n; i++)
            {
                dp[i] = Math.Max(dp[i - 1] + a[i], a[i]);
                ans = Math.Max(dp[i], ans);
            }

            Console.WriteLine(ans);
        }
    }
}
