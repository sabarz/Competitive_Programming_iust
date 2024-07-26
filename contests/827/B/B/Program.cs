using System;
using System.Collections.Generic;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> ans = new List<string>();
            for(int i = 0; i < n; i ++)
            {
                int m = int.Parse(Console.ReadLine());
                Dictionary<int, bool> d = new Dictionary<int, bool>();
                string[] s = Console.ReadLine().Split(' ');
                bool hi = false;

                for(int j = 0; j < m; j ++)
                {
                    if(d.ContainsKey(int.Parse(s[j])))
                    {
                        ans.Add("NO");
                        hi = true;
                        break;
                    }
                    else
                    {
                        d.Add(int.Parse(s[j]), true);
                    }
                }
                if(!hi)
                {
                    ans.Add("YES");
                }
            }

            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
