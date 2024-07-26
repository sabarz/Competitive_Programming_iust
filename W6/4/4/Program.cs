using System;
using System.Collections.Generic;

namespace _4
{
    class Program
    {
        public static long pow(int n , int k)
        {
            long ans = 1;
            for(int i = 0; i < k; i ++)
            {
                ans *= n;
                ans %= (long)Math.Pow(10, 9 ) + 7;
            }
            return ans;
        }
        public static long N = pow(10, 9) + 7; 

        public static List<int> DFS(Dictionary<int, List<int>> d, int n)
        {
            bool[] visit = new bool[n + 1];
            List<int> g = new List<int>();
            for(int i = 1; i <= n; i ++)
            {
                if (!visit[i])
                {
                    int ans = 0;
                    Stack<int> s = new Stack<int>();
                    visit[i] = true;
                    s.Push(i);

                    while (s.Count != 0)
                    {
                        int hold = s.Pop();
                        ans++;
                        if (!visit[hold])
                        {
                            visit[hold] = true;
                        }

                        if (d.ContainsKey(hold))
                        {
                            foreach (var it in d[hold])
                            {
                                if (!visit[it])
                                    s.Push(it);
                            }
                        }
                    }

                    g.Add(ans);

                }
            }

            return g;
        }
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            Dictionary<int, List<int>> d = new Dictionary<int, List<int>>();
            for(int i = 0; i < n - 1; i ++)
            {
                s = Console.ReadLine().Split();
                if (int.Parse(s[2]) == 0)
                {
                    if (!d.ContainsKey(int.Parse(s[0])))
                        d.Add(int.Parse(s[0]), new List<int>());

                    d[int.Parse(s[0])].Add(int.Parse(s[1])); 

                    if(!d.ContainsKey(int.Parse(s[1])))
                        d.Add(int.Parse(s[1]) , new List<int>());
                    d[int.Parse(s[1])].Add(int.Parse(s[0]));
                }
            }

            List<int> hi = DFS(d, n);
            long hold = 0;
            for(int i = 0; i < hi.Count; i ++)
            {
           //     Console.WriteLine(hi[i]);
                hold += pow(hi[i], k) % N;
                hold %= N;
            }
            long w = (pow(n, k) - hold + N) % N;
            Console.WriteLine(w);
        }
    }
}
