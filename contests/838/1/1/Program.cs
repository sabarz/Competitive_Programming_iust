using System;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<int> ans = new List<int>();

            for(int i = 0; i < t; i ++)
            {
                int n = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split();
                int[] a = new int[n];
                int[] dp = new int[n];
                int hi = 0;
                for (int j = 0; j < n; j++)
                {
                    a[j] = int.Parse(s[j]);
                    hi += a[j];
                }
                if (hi % 2 != 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        bool odd = false;
                        if (a[j] % 2 == 0)
                        {
                            odd = true;
                        }
                        else
                        {
                            odd = false;
                        }
                        int hold = a[j], cnt = 0;
                        while (true)
                        {
                            hold /= 2;
                            cnt++;
                            if (hold % 2 == 1 && odd)
                            {
                                dp[j] = cnt;
                                break;
                            }
                            else if (hold % 2 == 0 && !odd)
                            {
                                dp[j] = cnt;
                                break;
                            }
                        }
                    }

                    int min = int.MaxValue;
                    for (int j = 0; j < n; j++)
                    {
                        min = Math.Min(min, dp[j]);
                    }

                    ans.Add(min);
                }
                else
                    ans.Add(0);
            }
            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
