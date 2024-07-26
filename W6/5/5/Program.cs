using System;
using System.Collections.Generic;

namespace _5
{
    class Program
    {
        public static int DFS(Dictionary<int, List<Tuple<int, int>>> d, int n)
        {
            bool[] visit = new bool[n];
            int[] dp = new int[n];

            Stack<int> s = new Stack<int>();
            visit[0] = true;
            s.Push(0);
            dp[0] = 0;

            while (s.Count != 0)
            {
                int hold = s.Pop();
                if (!visit[hold])
                {
                    visit[hold] = true;
                }
                foreach (var it in d[hold])
                {
                    if (!visit[it.Item1])
                    {
                        s.Push(it.Item1);
                        dp[it.Item1] = Math.Max(dp[it.Item1], dp[hold] + it.Item2);
                    }
                }
            }
            int ans = 0;
            for (int i = 0; i < n; i++)
                ans = Math.Max(ans, dp[i]);

            return ans;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, List<Tuple<int, int>>> d = new Dictionary<int, List<Tuple<int, int>>>();
            long ans = 0;

            for(int i = 0; i < n; i ++)
            {
                d.Add(i, new List<Tuple<int, int>>());
            }
            for(int i = 0; i < n - 1; i ++)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]) - 1, b = int.Parse(s[1]) - 1, w = int.Parse(s[2]);

                d[a].Add(new Tuple<int, int>(b , w));
                d[b].Add(new Tuple<int, int>(a , w));

                ans += (2 * w);
            }

            int cnt = DFS(d, n);

            Console.WriteLine(ans - cnt);
        }
    }
}
