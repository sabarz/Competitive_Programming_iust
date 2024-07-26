using System;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        public static int dfsAAAAA(List<List<Tuple<int, int>>> dWithourDirection, int n)
        {
            Stack<int> s = new Stack<int>();
            bool[] visited = new bool[n];
            int ans = 0;
            s.Push(0);
            
            while(s.Count != 0)
            {
                int hold = s.Pop();
                visited[hold] = true;

                for(int i = 0; i < dWithourDirection[hold].Count; i++)
                {
                    if(dWithourDirection[hold][i].Item2 == 0 && !visited[dWithourDirection[hold][i].Item1])
                    {
                        ans++;
                    }
                    if(!visited[dWithourDirection[hold][i].Item1])
                        s.Push(dWithourDirection[hold][i].Item1);
                }
            }

            return ans;

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] d = new int[n, n];

            List<List<Tuple<int , int>>> dWithourDirection = new List<List<Tuple<int, int>>>();

            for (int i = 0; i < n ; i++)
            {
                dWithourDirection.Add(new List<Tuple<int, int>>());
            }
            for (int i = 0; i < n - 1; i ++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int a = int.Parse(s[0]) - 1, b = int.Parse(s[1]) - 1;

                dWithourDirection[a].Add(new Tuple<int , int>(b , 1));

                dWithourDirection[b].Add(new Tuple<int, int>(a, 0));
            }

            int[] dp = new int[n];
            dp[0] = dfsAAAAA(dWithourDirection, n);
            
            Stack<int> st = new Stack<int>();
            bool[] visited = new bool[n];
           
            st.Push(0);
            while (st.Count != 0)
            {
                int hold = st.Pop();
                visited[hold] = true;

                for (int i = 0; i < dWithourDirection[hold].Count; i++)
                {
                    if (dWithourDirection[hold][i].Item2 == 0 && !visited[dWithourDirection[hold][i].Item1])
                    {
                        dp[dWithourDirection[hold][i].Item1] = dp[hold] - 1;
                        //min = Math.Min(min, dp[dWithourDirection[hold][i].Item1]); 
                    } 
                    else if (dWithourDirection[hold][i].Item2 == 1 && !visited[dWithourDirection[hold][i].Item1])
                    {
                        dp[dWithourDirection[hold][i].Item1] = dp[hold] + 1;
                        //min = Math.Min(min, dp[dWithourDirection[hold][i].Item1]);
                    }

                    if (!visited[dWithourDirection[hold][i].Item1])
                        st.Push(dWithourDirection[hold][i].Item1);
                }
            }

            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
                min = Math.Min(min, dp[i]);

            Console.WriteLine(min);

            for (int i = 0; i < n; i ++)
            {
                if(dp[i] == min)
                {
                    Console.Write((i + 1).ToString() + " ");
                }
            }
            
        }
    }
}

