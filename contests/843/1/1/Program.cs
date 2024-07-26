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
                string hi = "";
                bool f = false;
                int m = s.Length;
                for(int j = 1; j < m - 1; j++)
                {
                    if(s[j] == 'a')
                    {
                        hi = s.Substring(0, j) + " " + 'a' +" " + s.Substring(j + 1);
                        ans.Add(hi);
                        f = true;
                        break;
                    }
                }
                if(!f)
                {
                    hi = s[0] + " " + s.Substring(1, m - 2) + " " + s[m - 1];
                    ans.Add(hi);
                }
            }

            foreach (var it in ans) Console.WriteLine(it);
        }
    }
}
