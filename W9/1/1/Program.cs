using System;
using System.Collections.Generic;

namespace _1
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
                seg_tree[index] = seg_tree[index * 2] + seg_tree[index * 2 + 1];
            }
        }
        public static long find(int l, int r, int L, int R, int index, ref long[] seg_tree)
        {
            if (l >= R || r <= L)
            {
                return 0;
            }
            else if (L >= l && r >= R)
            {
                return seg_tree[index];
            }
            else
            {
                return find(l, r, L, (R + L) / 2, 2 * index, ref seg_tree) + find(l, r, (R + L) / 2, R, 2 * index + 1, ref seg_tree);
            }
        }
        public static void change(int l, int r, int index, int x, int i, ref long[] seg_tree)
        {
            if (r - l == 1)
            {
                seg_tree[index] = x;
                return;
            }
            else if (i >= (r + l) / 2)
            {
                change((r + l) / 2, r, 2 * index + 1, x, i, ref seg_tree);
            }
            else if (i < (r + l) / 2)
            {
                change(l, (r + l) / 2, 2 * index, x, i, ref seg_tree);
            }
            seg_tree[index] = seg_tree[index * 2] + seg_tree[index * 2 + 1];

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
                int t = int.Parse(s[0]), l = int.Parse(s[1]) - 1, r = int.Parse(s[2]) - 1;
                if (t == 1)
                {
                    ans.Add(find(l, r + 1, 0, n, 1, ref seg_tree));

                }
                else
                {
                    change(0, n, 1, r + 1, l, ref seg_tree);
                }
            }
            foreach (var it in ans) Console.WriteLine(it);
        }
    }
}
