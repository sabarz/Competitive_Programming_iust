using System;
using System.Collections.Generic;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> ans = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                int x = int.Parse(s[0]);
                int y = int.Parse(s[1]);
                
                for(int j = 0; j < y; j++)
                {
                    s = Console.ReadLine().Split(' ');
                }
                if(y < x)
                {
                    ans.Add("YES");
                }
                else
                {
                    ans.Add("NO");
                }

            }

            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
