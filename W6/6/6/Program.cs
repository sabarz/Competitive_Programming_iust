using System;
using System.Collections.Generic;

namespace _6
{
    class Program
    {
        public static bool DFS(Dictionary<int, List<int>> d, int n)
        {
            bool[] visit = new bool[n];
            int vay = 0;

            for (int i = 0; i < n; i++)
            { 
                if (!visit[i])
                {
                    if(d[i].Count != 0)
                        vay++;
                    if(vay > 1)
                    { return false; }

                    Stack<int> s = new Stack<int>();
                    visit[i] = true;
                    s.Push(i);

                    while (s.Count != 0)
                    {
                        int hold = s.Pop();
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
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            int[] degree = new int[n];
            Dictionary<int, List<int>> d = new Dictionary<int, List<int>>();

            for(int i = 0; i < n; i ++)
            {
                d.Add(i, new List<int>());
            }
            for (int i = 0; i < m; i ++)
            {
                s = Console.ReadLine().Split();
                int a = int.Parse(s[0]) - 1, b = int.Parse(s[1]) - 1;
                degree[a]++;
                degree[b]++;

                d[a].Add(b);
                d[b].Add(a);
            }
            int odd = 0;

            for(int i = 0; i < n; i ++)
            {
                if (degree[i] % 2 == 1)
                {
                    odd++; 
                }
            }

            if(!DFS(d , n))
                Console.WriteLine("NO");
            else if (odd == 2 ||odd == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
    
}
