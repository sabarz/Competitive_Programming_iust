using System;
using System.Collections.Generic;


namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> ans = new List<int>();

            for(int i = 0; i < n; i ++)
            {
                int m = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();
                /*int[] dp = new int[m];
                dp[0] = 0;*/
                int hold = 0;
                for(int j = 1; j < m; j++)
                {
                    if(s[j] != s[j - 1])
                    {
                        hold++;
                    }
              
                }

                if(s[0] == '0')
                {
                    hold -= 1;
                }
                if(hold < 0)
                {
                    ans.Add(0);
                }
                else
                {
                    ans.Add(hold);
                }

            }    

            foreach(var it in ans)
            {
                Console.WriteLine(it);
            }
        }
    }
}
