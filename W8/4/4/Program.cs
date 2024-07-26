using System;
using System.Collections.Generic;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int[] arr = new int[n];
            long[,] dp = new long[n, 21];
            List<long> ans = new List<long>();

            for(int i = 0; i < n; i ++)
            {
                arr[i] = int.Parse(s[i]);
            }

            int q = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                dp[i, 0] = 0;
            }

            for(int i = n - 1; i >= 0; i --)
            {
                for(int j = 1; j <= 20; j++)
                {
                    if(j + i >= n)
                    {
                        dp[i, j] = arr[i]; 
                    }
                    else
                    {
                        dp[i, j] = dp[i + j, j] + arr[i];
                    }
                }
            }
            for(int i = 0; i < q; i ++)         
            {
                s = Console.ReadLine().Split();
                int a = int.Parse(s[0]) - 1 , b = int.Parse(s[1]);
                if (b > 20)
                {
                    long hold = 0;
                    for (int j = a; j < n; j += b)
                    {
                        hold += arr[j];
                    }
                    ans.Add(hold);
                }
                else
                    ans.Add(dp[a, b]);
            }

            foreach (var it in ans) Console.WriteLine(it);

        }
    }
}
