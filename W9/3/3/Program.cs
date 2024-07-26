using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int[] a = new int[n];
            int[] hold = new int[n];
            Dictionary<int, int> d = new Dictionary<int, int>();

            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
                if (d.ContainsKey(a[i]))
                   hold[i] = d[a[i]]++;
                else
                    d.Add(a[i], 1);
            }

            long ans = 0;
            int[] nmd = new int[n];
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = hold[i]; j != 0; j -= (j & -j))
                {
                    ans += nmd[j];
                }
                for (int j = d[a[i]] - hold[i]; j < n; j += (j & -j))
                {
                    nmd[j]++;
                }
            }
            Console.WriteLine(ans);

        }
    }
}
