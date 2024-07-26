using System;
using System.Collections.Generic;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int q = int.Parse(s[1]);
            s = Console.ReadLine().Split();
            long[] arr = new long[n];
            long[] jump = new long[n];
            long[] next = new long[n];
            List<Tuple<long, long>> ans = new List<Tuple<long, long>>();

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            long size = (long)Math.Sqrt(n); 
            for(int i = n - 1; i >= 0; i--)
            {
                if(i + 1 + arr[i] > n)
                {
                    jump[i] = 1;
                    next[i] = n + 1;
                }
                else if (((i + arr[i]) / size) == (i / size))
                {
                    jump[i] = 1 + jump[i + arr[i]];
                    next[i] = next[i + arr[i]];
                }
                else
                {
                    jump[i] = 1;
                    next[i] = i + arr[i];
                }
            }

            for(int i = 0; i < q; i++)
            {
                s = Console.ReadLine().Split();
                int t = int.Parse(s[0]);

                if(t == 0)
                {
                    int a = int.Parse(s[1]), b = int.Parse(s[2]);
                    arr[a - 1] = b;
                    for (int j = a - 1; j >= ((a - 1) / size) * size; j--)
                    {
                        if (j + 1 + arr[j] > n)
                        {
                            jump[j] = 1;
                            next[j] = n + 1;
                        }
                        else if (((j + arr[j]) / size) == (j / size))
                        {
                            jump[j] = 1 + jump[j + arr[j]];
                            next[j] = next[j + arr[j]];
                        }
                        else
                        {
                            jump[j] = 1;
                            next[j] = j + arr[j];
                        }
                    }
                }
                else
                {
                    long a = int.Parse(s[1]);
                    long hold = 0;
                    a--;
                    long final = a;
                    while (a < n)
                    {
                        hold += jump[a];
                        
                        if (next[a] >= n)
                            break;

                        a = next[a];
                        final = a;
                    }
                    while (final < n)
                    {
                        a = final;
                        final = final + arr[final];
                    }
                    ans.Add(new Tuple<long, long>(a + 1 , hold));
                }
            }

            foreach (var it in ans) Console.WriteLine(it.Item1 + " " + it.Item2);
        }
 
    }
}
