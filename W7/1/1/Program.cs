using System;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        public static int lca(int u, int v, int[,] dp, int[] level, int[] par)
        {
            int distance = level[u] - level[v];

            for (int i = 20; i >= 0; i--)
            {
                if (((1 << i) & distance) > 0)
                {
                    u = dp[u, i];
                }
            }
            if (v == u)
                return u + 1;

            for (int i = 20; i >= 0; i--)
            {
                if (dp[u, i] != dp[v, i])
                {
                    u = dp[u, i];
                    v = dp[v, i];
                }
            }
            return par[u] + 1;
        }
        public static int[] DFS(Dictionary<int, List<int>> d, int n, int[] par)
        {
            Stack<int> s = new Stack<int>();
            bool[] visited = new bool[n];
            int[] level = new int[n];
            level[0] = 0;
            s.Push(0);

            while (s.Count != 0)
            {
                int hold = s.Pop();
                level[hold] = level[par[hold]] + 1;
                visited[hold] = true;

                for (int i = 0; i < d[hold].Count; i++)
                {
                    if (!visited[d[hold][i]])
                        s.Push(d[hold][i]);
                }
            }
            return level;
        }
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int q = int.Parse(s[1]);
            s = Console.ReadLine().Split();
            Dictionary<int, List<int>> d = new Dictionary<int, List<int>>();

            int[] par = new int[n];
            par[0] = 0;
            d.Add(0, new List<int>());

            for (int i = 1; i < n; i++)
            {
                par[i] = int.Parse(s[i - 1]) - 1;

                if (!d.ContainsKey(i))
                    d.Add(i, new List<int>());
                d[i].Add(par[i]);

                if (!d.ContainsKey(par[i]))
                    d.Add(par[i], new List<int>());
                d[par[i]].Add(i);
            }

            int[] level = DFS(d, n, par);
            int[,] dp = new int[n, 21];

            for (int i = 0; i < n; i++)
                dp[i, 0] = par[i];

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    dp[i, j] = dp[dp[i, j - 1], j - 1];
                }
            }

            List<int> ans = new List<int>();
            for (int i = 0; i < q; i++)
            {
                s = Console.ReadLine().Split();
                int a = int.Parse(s[0]) - 1, b = int.Parse(s[1]) - 1;

                if (level[a] > level[b])
                    ans.Add(lca(a, b, dp, level, par));
                else
                    ans.Add(lca(b, a, dp, level, par));

            }
            foreach (var it in ans) Console.WriteLine(it);
        }
    }
}
