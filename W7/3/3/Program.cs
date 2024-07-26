using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        public static int find(int node, int[] lnodes)
        {
            if (lnodes[node] != node)
                lnodes[node] = find(lnodes[node], lnodes);
            return lnodes[node];
        }
        public static void union(int[] lnodes, int f, int s)
        {
            int froot = find(f, lnodes);
            int sroot = find(s, lnodes);

            if (froot != sroot)
            {
                lnodes[froot] = sroot;
            }
        }
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int q = int.Parse(s[1]);
            int[] par = new int[n + 1];
            int[] unMatched = new int[n + 1];
            List<string> ans = new List<string>();

            for(int i = 1; i <= n; i ++)
            {
                par[i] = i;
                unMatched[i] = i + 1;
            }

            for (int i = 0; i < q; i++)
            {
                s = Console.ReadLine().Split();
                int a = int.Parse(s[0]), b = int.Parse(s[1]), c = int.Parse(s[2]);
                if(a == 1)
                {
                    union(par, b, c);
                }
                else if(a == 2)
                {
                    int j = b;
                    int hold = j + 1;
                    while(hold <= c)
                    {
                        union(par, j, hold);
                        hold = unMatched[j + 1];
                        unMatched[j + 1] = unMatched[c];
                        j = hold - 1;
                    }
                }
                else
                {
                    int froot = find(b, par);
                    int rroot = find(c, par);
                    if (froot == rroot)
                        ans.Add("YES");
                    else
                        ans.Add("NO");
                }
            }

            foreach (var it in ans) Console.WriteLine(it);
        }
    }
}
