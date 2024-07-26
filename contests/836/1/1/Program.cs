using System;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> ans = new List<string>();

            for(int i = 0; i < n; i ++)
            {
                string s = Console.ReadLine();
                string hold = "";
                for(int j = s.Length - 1; j >= 0; j --)
                {
                    hold += s[j];
                }
                ans.Add(s + hold);
            }

            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
