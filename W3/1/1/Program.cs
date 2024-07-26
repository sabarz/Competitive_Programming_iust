using System;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n1 = int.Parse(s[0]);
            int n2 = int.Parse(s[1]);
            int[] a = new int[n1];
            int[] b = new int[n2];

            s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n1; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n2; i++)
            {
                b[i] = int.Parse(s[i]);
            }

            int[,] dp = new int[n1 + 1, n2 + 1];

            for(int i = 0; i < n1; i++)
            {
                dp[i, 0] = 0;
            }
            for(int i = 0; i < n2; i++)
            {
                dp[0, i] = 0;
            }
            for(int i = 1; i <= n1; i++)
            {
                for(int j = 1; j <= n2; j++)
                {
                    if(a[i - 1] == b[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j] , dp[i , j - 1]);
                    }
                }
            }

             Console.WriteLine(dp[n1, n2]);

        }
    }
}
