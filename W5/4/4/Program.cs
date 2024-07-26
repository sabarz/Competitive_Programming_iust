using System;
using System.Collections.Generic;

namespace _4
{
    class Program
    {
        public static int ans = 0;
        public static void DFS(Dictionary<int, List<int>> d , int[,] dp , int node ,bool[] check , int k)
        {
            dp[node, 0] = 1;
            check[node] = true;
            
            for(int i = 0; i < d[node].Count; i++)
            {
                if(!check[d[node][i]])
                {
                    DFS(d, dp, d[node][i], check , k);
                    ans += dp[d[node][i] , k - 1]; 
                    for(int j = 0; j < k - 1; j ++)
                    {
                        ans += dp[d[node][i], j] * dp[node, k - 1 - j];
                    }
                    for(int j = 1; j <= k; j++)
                    {
                        dp[node , j] += dp[d[node][i], j - 1];
                    }
                }

            }
        }

        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            Dictionary<int, List<int>> d = new Dictionary<int, List<int>>();
            bool[] check = new bool[n];

            for (int i = 0; i < n - 1; i ++)
            {
                s = Console.ReadLine().Split();
                int a = int.Parse(s[0]) - 1, b = int.Parse(s[1]) - 1;
                
                if (!d.ContainsKey(a))
                    d.Add(a, new List<int>());
                d[a].Add(b);
                if (!d.ContainsKey(b))
                    d.Add(b, new List<int>());
                d[b].Add(a);
            }
            int[,] dp = new int[n, k + 1];
            DFS(d, dp, 0, check, k);
            Console.WriteLine(ans); 
        }
    }
}
