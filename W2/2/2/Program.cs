using System;
using System.Linq;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int house = int.Parse(s[0]);
            int n = int.Parse(s[1]);
            List<Tuple<int, int>> baze = new List<Tuple<int, int>>();

            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split(' ');
                baze.Add(new Tuple<int, int>(int.Parse(s[0]) , int.Parse(s[1])));
            }
            baze = baze.OrderBy(x => x.Item1).ThenByDescending(x => x.Item2).ToList();
            int[] a = new int[house + 1];
            int[] dp = new int[house + 1];
            a[0] = 0;

            for(int i = 1; i <= baze[0].Item1; i ++)
            {
                a[i] = i - 1;
            }
            int index = baze[0].Item1;

            for(int i = 0; i < n; i ++)
            {
                for(int j = index; j <= baze[i].Item1; j ++)
                {
                    a[j] = j - 1;
                    index++;
                }
               // index = baze[i].Item1 + 1; 
                for (int j = index; j <= baze[i].Item2; j++)
                {
                    a[j] = baze[i].Item1 - 1;
                    index++;
                }
                //index = baze[i].Item2 + 1;
            }
            for(int i = index; i <= house; i ++)
            {
                a[i] = i - 1;
            }
            for(int i = 1; i <= house; i++)
            {
                dp[i] = dp[a[i]] + 1;
            }
/*            foreach (var it in a)
                Console.WriteLine(it);
*/
            Console.WriteLine(dp[house]);

        }
    }
}
