using System;
using System.Collections.Generic;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> ans = new List<string>();
            
            for(int i = 0; i < n; i ++)
            {
                bool hi = false;
                string[,] idk = new string[8, 8];
                int[] cnt2 = new int[8];
                string ah = Console.ReadLine();
                for (int k = 0; k < 8; k ++)
                {
                    string s = Console.ReadLine();
                    int cnt = 0;
                    for(int p = 0; p < 8; p ++)
                    {
                        idk[k, p] = s[p].ToString();
                        if(s[p] == 'R')
                        {
                            cnt++;
                        }
                    }
                    if(cnt == 8)
                    {
                        hi = true;
                    } 
                }
                if (hi == true)
                {
                    ans.Add("R");
                }
                else
                    ans.Add("B");
            }

            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
