using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split(' ');
            int n = int.Parse(s1[0]);
            int m = int.Parse(s1[1]);
            List<Tuple<int, int, int>> g = new List<Tuple<int, int, int>>();

            for (int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                g.Add(new Tuple<int, int, int>(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2])));
            }
            g = g.OrderBy(x => x.Item3).ToList();

            int[] dp = new int[n + 1];
            int index = 0;
            while (index < m)
            {
                List<int> hi = new List<int>();
                for (int i = 0; i <= m; i++)
                {
                    if (index + i >= m || g[index].Item3 != g[index + i].Item3)
                    {
                        for (int p = 0; p < hi.Count; p++)
                        {
                            dp[g[index + p].Item2] = hi[p];
                            dp[g[index + p].Item1] = hi[p] - 1;
                        }
                        index += i;
                        break;
                    }
                    else
                    {
                        hi.Add(Math.Max(dp[g[index + i].Item1] + 1, dp[g[index + i].Item2]));
                    }
                }
            }

            int ans = int.MinValue;
            for (int i = 1; i < n + 1; i++)
            {
                ans = Math.Max(ans, dp[i]);
            }
            Console.WriteLine(ans);
        }

    }
}
