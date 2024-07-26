using System;
using System.Collections.Generic;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> ans = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                m = 10 - m;
                if (m == 0)
                {
                    ans.Add(0);
                }
                else
                {
                    ans.Add(((m * (m - 1)) / 2) * 6);
                }
            }
            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
