using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        public static void segment_tree(int l, int r, int index, ref long[] seg_tree, int[] a)
        {
            if (r - l == 1)
            {
                seg_tree[index] = a[l];
                return;
            }
            else
            {
                segment_tree(l, (l + r) / 2, 2 * index, ref seg_tree, a);
                segment_tree((l + r) / 2, r, 2 * index + 1, ref seg_tree, a);
                seg_tree[index] = Math.Max(seg_tree[index * 2], seg_tree[index * 2 + 1]);
            }
        }
        public static long find(int l, int r, int L, int R, int index, ref long[] seg_tree , int x)
        {
            if (l >= R || r <= L || seg_tree[index] < x)
            {
                return -1;
            }
            else if (R - L == 1)
            {
                return L + 1;
            }
            else
            {
                long hold;
                if ((hold = find(l, r, L, (L + R) / 2, 2 * index, ref seg_tree, x)) != -1)
                {
                    return hold;
                }
                else
                {
                    return find(l, r, (L + R) / 2 , R, 2 * index + 1, ref seg_tree, x);
                }
            }
        }
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int q = int.Parse(s[1]);
            s = Console.ReadLine().Split();
            int[] a = new int[n];
            List<long> ans = new List<long>();

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            long[] seg_tree = new long[4 * n];

            segment_tree(0, n, 1, ref seg_tree, a);

            for (int i = 0; i < q; i++)
            {
                s = Console.ReadLine().Split();
                int l = int.Parse(s[0]) - 1, r = int.Parse(s[1]) , x = int.Parse(s[2]);

                ans.Add(find(l , r, 0 , n , 1 , ref seg_tree , x));

            }
            foreach (var it in ans) Console.WriteLine(it);
        }
    }
}
