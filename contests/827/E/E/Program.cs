using System;
using System.Linq;
using System.Collections.Generic;

namespace E
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<List<long>> ans = new List<List<long>>();

            for(int i = 0; i < n; i ++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int p = int.Parse(s[0]);
                int t = int.Parse(s[1]);
                int[] a = new int[p];
                List<int> k = new List<int>();
                Dictionary<int, int> god = new Dictionary<int, int>();

                s = Console.ReadLine().Split(' ');
                for(int j = 0; j < p; j ++)
                {
                    a[j] = int.Parse(s[j]);
                }
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < t; j++)
                {
                    k.Add(int.Parse(s[j]));
                    god[int.Parse(s[j])] = j;
                }

                k.Sort();
                long[] answer = new long[t];
                int index = 0;
                long cnt = 0;
                bool[] check = new bool[p];

                for (int w = 0; w < t; w++)
                {
                    for (int j = index; j < p; j++)
                    {
                        if (k[w] >= a[j] && !check[j])
                        {
                            cnt += a[j];
                            check[j] = true;
                        }
                        else
                        {
                            index = j;
                            break;
                        }
                    }
                    answer[god[k[w]]] = cnt;
                }

                ans.Add(answer.ToList());
            }

            /*foreach (var it in ans)
            {
                foreach (var it2 in it)
                {
                    Console.Write(it2 + " ");
                }
                Console.WriteLine();
            }*/

            for(int i = 0; i < ans.Count; i ++)
            {
                for(int j = 0; j < ans[i].Count; j ++)
                {
                    Console.Write(ans[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
