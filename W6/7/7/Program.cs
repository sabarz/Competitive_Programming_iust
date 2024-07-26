using System;
using System.Collections.Generic;

namespace _7
{
    class Program
    {
        //0 red    1 blue
        public static void BFS(Dictionary<int, List<int>> d, int[] color, ref int[,] dp , int n , bool[] visited , int current)
        {
            visited[current] = true;
           // bool isleaf = true;

            foreach (var it in d[current])
            {
                if (visited[it] == false)
                {
                    BFS(d, color, ref dp, n, visited, it);
                    dp[current, 0] += dp[it, 0];
                    dp[current, 1] += dp[it, 1];
                    //isleaf = false;
                }
            }
           /* if(isleaf)
            {*/
               /* if (d[current].Count == 1)
                {*/
                    if (color[current] == 1)
                        dp[current, 0] += 1;
                    else if (color[current] == 2)
                        dp[current, 1] += 1;
               // }
           // }
          
            
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int[] color = new int[n];
            Dictionary<int, List<int>> d = new Dictionary<int, List<int>>();
            int blue = 0, red = 0;
               
            for (int i = 0; i < n; i++)
            {
                color[i] = int.Parse(s[i]);
                    
                if (color[i] == 1)
                    red++;
                else if (color[i] == 2)
                    blue++;

                d.Add(i, new List<int>());
            }
            for (int i = 0; i < n - 1; i++)
            {
                s = Console.ReadLine().Split();
                int a = int.Parse(s[0]) - 1, b = int.Parse(s[1]) - 1;
                d[a].Add(b);
                d[b].Add(a);
            }

            int[,] dp = new int[n, 2];
            bool[] visit = new bool[n];
            BFS(d, color, ref dp , n , visit , 0);

            /*for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dp[i, 0] + "    " + dp[i, 1]);
            }*/
            int ans = 0;
            for(int i = 1; i < n; i ++)
            {
                if (dp[i, 0] == red && dp[i, 1] == 0)
                    ans++;
                if (dp[i, 1] == blue && dp[i, 0] == 0)
                    ans++;
            }

            Console.WriteLine(ans);
        }
    }
}

