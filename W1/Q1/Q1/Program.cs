using System;
using System.Collections.Generic;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> ans = new List<string>();

            for(int i = 0; i < n; i ++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 1900)
                    ans.Add("Division 1");
                else if (x >= 1600 && x <= 1899)
                    ans.Add("Division 2");
                else if (x >= 1400 && x <= 1599)
                    ans.Add("Division 3");
                else
                    ans.Add("Division 4");
            }

            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
