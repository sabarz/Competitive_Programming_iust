using System;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<long> ans = new List<long>();

            for(int i = 0; i < t; i ++)
            {
                long n = long.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split();
                int[] a = new int[n];
                int max = int.MinValue, min = int.MaxValue;
                long hi = 0, by = 0;

                for(int j = 0; j < n; j ++)
                {
                    a[j] = int.Parse(s[j]);
                    max = Math.Max(max, a[j]);
                    min = Math.Min(min, a[j]);
                }
                for(int j = 0; j < n; j ++)
                {
                    if (max == a[j])
                        by++;
                    if (min == a[j])
                        hi++;
                }
                long nmd = 0;
                if (max == min)
                {
                    nmd = n * (n - 1);
                }
                else
                {
                    nmd = 2 * hi * by;
                }
                ans.Add(nmd);
            }

            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
