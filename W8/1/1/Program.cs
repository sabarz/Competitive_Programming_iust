using System;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int q = int.Parse(s[1]);
            s = Console.ReadLine().Split();
            int[] a = new int[n];
            long[] dp = new long[n + 1];
            long sum = 0;
            List<long> ans = new List<long>();
            
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
                sum += a[i];
                dp[i + 1] = sum;
            }

            for(int i = 0; i < q; i ++)
            {
                s = Console.ReadLine().Split();
                int l = int.Parse(s[0]) - 1, r = int.Parse(s[1]) - 1;
                ans.Add(dp[r + 1] - dp[l]);
            }

            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
