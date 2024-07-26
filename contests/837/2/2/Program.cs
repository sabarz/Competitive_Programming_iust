using System;
using System.Linq;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<long> ans = new List<long>();

            for(int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split();
                List<Tuple<int ,int>> hi = new List<Tuple<int, int>>();
                long n = int.Parse(s[0]);
                int m = int.Parse(s[1]);

                for(int j = 0; j < m; j++)
                {
                    s = Console.ReadLine().Split();

                    hi.Add(new Tuple<int, int>(Math.Min(int.Parse(s[0]), int.Parse(s[1])) , Math.Max(int.Parse(s[0]), int.Parse(s[1]))));
                }
                hi = hi.OrderBy(x => x.Item1).ToList();
                long nmd = 0;
                int[] dp = new int[m + 1];
                dp[m] = int.MaxValue;
                int index = 0;

                for(int j = m - 1; j >= 0; j--)
                {
                    dp[j] = Math.Min(hi[j].Item2, dp[j + 1]);
                }

                for(int j = 1; j <= n; j ++)
                {
                    while(index < m && hi[index].Item1 < j)
                    {
                        index++;
                    }
                    if (index >= m)
                    {
                        long y = (n - j) + 1;
                        nmd += (y * (y + 1)) / 2;
                        break;
                    }
                    else
                    {
                        nmd += (dp[index] - j);
                    }
                }

                ans.Add(nmd);
            }

            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
