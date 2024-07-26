using System;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        public static long find(int l, int r, int L, int R, int index, ref long[] seg_tree)
        {
            if (L >= l && r >= R)
            {
                return seg_tree[index];
            }
            else if (L > r || R < l)
            {
                return 0;
            }     
            else
            {
                return find(l, r, L, (R + L) / 2, 2 * index + 1, ref seg_tree) + find(l, r, ((R + L) / 2) + 1, R, 2 * index + 2, ref seg_tree);
            }
        }
        public static void change(int l, int r, int index, int i, ref long[] seg_tree)
        {
            if(i < l || i > r)
            {
                return;
            }
            seg_tree[index]++;
            if (l - r != 0)
            {
                change(l, (l + r) / 2, 2 * index + 1, i, ref seg_tree);
                change(((l + r) / 2) + 1 , r, 2 * index + 2, i, ref seg_tree);
            }

        }
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            long[] seg_tree = new long[4 * n];
            long ans = 0;

            for(int i = 0; i < n; i ++)
            {
                ans += find(a[i] + 1, n, 0, n, 0, ref seg_tree);
                ans %= 100000;
                change(0, n, 0, a[i], ref seg_tree);
            }
            Console.WriteLine(ans);
        }
    }
}
