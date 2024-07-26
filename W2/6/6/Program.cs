using System;
using System.Collections.Generic;

namespace _6
{
    class Program
    {
        public static long check(List<Tuple<int , int>> l , long day , int n , int money)
        {
            long cnt = 0;

            for(int i = 0; i < n; i ++)
            {
                long hold = day * l[i].Item1 - l[i].Item2;
                if (hold > 0)
                {
                    cnt += hold;
                    if (cnt >= money)
                        return cnt;
                }
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            List<Tuple<int, int>> listOfP = new List<Tuple<int, int>>();

            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split(' ');
                listOfP.Add(new Tuple<int, int>(int.Parse(s[0]), int.Parse(s[1])));
            }

            long l = 0, r = 4000000000;
            while(r - l > 1)
            {
                long mid = (l + r) / 2;

                if(check(listOfP , mid , n , m) >= m)
                {
                    r = mid;
                }
                else
                {
                    l = mid;
                }
            }
            Console.WriteLine(r);
        }
    }
}
