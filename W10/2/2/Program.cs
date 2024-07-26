using System;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        public static int BinarySearch(List<int> d, int key)
        {
            int l = 0, r = d.Count - 1, mid;

            if(r + 1 == 1)
            {
                if (d[0] == key)
                    return 0;
                else
                    return -1;
            }
            while (r - l > 1)
            {
                mid = (l + r) / 2;
                if (d[mid] >= key)
                {
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }

            if (d[r] == key)
                return r;
            return l;
        }
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int q = int.Parse(s[1]);
            int[] a = new int[n];
            s = Console.ReadLine().Split();
            Dictionary<int, List<int>> d = new Dictionary<int, List<int>>();

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
                if (!d.ContainsKey(a[i]))
                    d.Add(a[i], new List<int>());
                d[a[i]].Add(i);
            }
            List<int> ans = new List<int>();
            for (int i = 0; i < q; i++)
            {
                s = Console.ReadLine().Split();
                int x = int.Parse(s[2]);
                int l = int.Parse(s[0]) - 1;
                int r = int.Parse(s[1]) - 1;

                int first = BinarySearch(d[x], l);
                int last = BinarySearch(d[x], r);

                if (last == -1)
                    Console.WriteLine(0);
                else if (first < 0 && last < 0)
                    Console.WriteLine(first - last);
                else if (first < 0)
                    Console.WriteLine(last - ((first + 2) * -1));
                else if (last < 0)
                    Console.WriteLine((last + 1) * -1 - first);
                else
                    Console.WriteLine(last - first + 1);
            }

            foreach (var it in ans) Console.WriteLine(it);

        }
    }
}
