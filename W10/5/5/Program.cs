using System;
using System.Linq;
using System.Collections.Generic;
namespace _5
{
    class Program
    {

       /* public static void update(long index , long val)
        {

        }*/
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            long[] a = new long[n];
            long[] s1 = new long[1001000];
            long[] s2 = new long[1001000];
            long ans = 0;
            List<Tuple<long, long>> copy = new List<Tuple<long, long>>();

            for(int i = 0; i < n; i ++)
            {
                a[i] = long.Parse(s[i]);
                copy.Add(new Tuple<long, long>(a[i], i + 1));
            }
            copy = copy.OrderBy(x => x.Item1).ToList();

            for(int i = (int)n - 1; i >= 0; i --)
            {
                long hold = 0;
                for (long j = copy[i].Item2 - 1; j != 0 ; j -= (j & (-j)))
                {
                    hold += s1[j];
                    ans += s2[j];
                }
                for(long j = copy[i].Item2; j < 1001000; j += (j & (-j)))
                {
                    s1[j]++;
                    s2[j] += hold;
                }
            }

            Console.WriteLine(ans);
        }
    }
}
