using System;
using System.Collections.Generic;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> d = new Dictionary<string, int>();

            for(int i = 0; i < n; i ++)
            {
                d.Add(Console.ReadLine(), i);
            }
            int q = int.Parse(Console.ReadLine());
            bool[] b = new bool[n];
            int hold = 0;
            int ans = 0;

            for(int i = 0; i < q; i ++)
            {
                string hi = Console.ReadLine();
                bool f = b[d[hi]];
                if (f == false)
                {
                    hold++;
                    b[d[hi]] = true;
                }
                if(hold == n)
                {
                    b = new bool[n];
                    b[d[hi]] = true;
                    hold = 1;
                    ans++;
                }
            }

            Console.WriteLine(ans);
        }
    }
}
