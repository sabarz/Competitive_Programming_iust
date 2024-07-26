using System;
using System.Linq;
using System.Collections.Generic;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<long> ans = new List<long>();

            for(int i = 0; i < n; i++)
            {
                int mon = int.Parse(Console.ReadLine());
                string[] s1 = Console.ReadLine().Split(' ');
                string[] s2 = Console.ReadLine().Split(' ');
                int[] a = new int[mon];
                int[] b = new int[mon];
                List<long> l = new List<long>();
                long answer = 0;

                for(int j = 0; j < mon; j++)
                {
                    a[j] = int.Parse(s1[j]);
                    b[j] = int.Parse(s2[j]);
                    if (j == 0 || j == mon - 1)
                    {
                        l.Add(b[j]);
                        answer += a[j];
                    }
                    else
                    {
                        l.Add(b[j] * 2);
                        answer += a[j];
                    }
                }

                long mid1 = Math.Min(b[0], b[mon - 1]);
                long mid2 = Math.Max(b[0], b[mon - 1]);
                l = l.OrderBy(x => x).ToList();
                bool check1 = false, check2 = false;

                for(int j = 0; j < mon - 1; j++)
                {
                    if(l[j] < mid1)
                    {
                        answer += l[j];
                    }
                    else if (l[j] == mid1)
                    {
                        if (check1)
                            answer += l[j] / 2;
                        else
                        {
                            answer += l[j];
                            check1 = true;
                        }
                    }
                    else if(l[j] > mid1 && l[j] < mid2)
                    {
                        answer += l[j];
                    }
                    else if(l[j] == mid2)
                    {
                        if(check2)
                        answer += l[j] / 2;
                        else
                        {
                            answer += l[j];
                            check2 = true;
                        }
                    }
                    else if(l[j] > mid2)
                    {
                        answer += l[j] / 2;
                    }
                }
                ans.Add(answer);
            }

            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
