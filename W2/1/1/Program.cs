using System;
using System.Linq;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            long k = int.Parse(s[1]);
            List<Tuple<int, int>> mive = new List<Tuple<int, int>>();

            for(int i = 0; i < n; i ++)
            {
                string[] s1 = Console.ReadLine().Split(' ');

                if(int.Parse(s1[1]) - int.Parse(s1[0]) > 0)
                    mive.Add(new Tuple<int, int>(int.Parse(s1[0]), int.Parse(s1[1]) - int.Parse(s1[0])));
            }

            mive = mive.OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToList();

            for(int i = 0; i < mive.Count; i ++)
            {
                //Console.WriteLine(mive[i].Item1+ " "+ mive[i].Item2);
                if(k >= mive[i].Item1)
                {
                    k += mive[i].Item2 ;
                }
            }

            Console.WriteLine(k);
        }
    }
}
