using System;
using System.Collections.Generic;

namespace _3
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
                bool hi = false , nmd = false;
                HashSet<int> h = new HashSet<int>();

                for (int p = 0; p < m; p++)
                {
                    string[] s = Console.ReadLine().Split();
                    int hold = 0;

                    for (int j = 1; j <= int.Parse(s[0]); j++)
                    {
                      
                        if (h.Contains(int.Parse(s[j])))
                        {
                            hold++;
                        }
                        if(hold == h.Count && hold != 0)
                        {
                            nmd = true;
                        }
                        if(!h.Contains(int.Parse(s[j])))
                        {
                            h.Add(int.Parse(s[j]));
                        }

                    }
                    if (hold == int.Parse(s[0]) && !hi || nmd)
                    {
                        ans.Add("yes");
                        hi = true;
                        nmd = false;
                    }
                    
                }
                if (!hi)
                    ans.Add("no");
            }

            foreach (var it in ans) Console.WriteLine(it);
        }
    }
}
