using System;
using System.Linq;
using System.Collections.Generic;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<List<int>> ans = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                int l = 0, r = m - 1;
                int[] a = new int[m];
                for (int j = 1; j <= m; j++)
                {
                    if (j % 2 == 0)
                    {
                        a[l++] = j;
                    }
                    else
                    {
                        a[r--] = j;
                    }
                }
                ans.Add(a.ToList());
            }

            for(int i = 0; i < ans.Count; i++)
            {
                foreach(var it in ans[i])
                Console.Write(it + " ");

                Console.WriteLine();
            }
        }
    }
}
