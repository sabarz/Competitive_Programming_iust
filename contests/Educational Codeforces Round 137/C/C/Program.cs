using System;
using System.Linq;
using System.Collections.Generic;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> ans = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                char[] s = Console.ReadLine().ToCharArray();
                string[] s2 = Console.ReadLine().Split(' ');
                int hold = 0;
                int hi = 0;

                for(int j = 0; j < m ; j++)
                {
                    if (s[j] == '1')
                    {
                        hi += int.Parse(s2[j]);
                    }
                    else if (j + 1 <= m - 1 && s[j] == '0' && s[j + 1] == '1' && int.Parse(s2[j]) >= int.Parse(s2[j + 1]))
                    {
                        hi += int.Parse(s2[j]);
                        s[j] = '1';
                        s[j + 1] = '0';
                    }
                    else if(j + 1 <= m - 1 && s[j] == '0' && s[j + 1] == '1' && int.Parse(s2[j]) < int.Parse(s2[j + 1]))
                    {
                        hold = int.Parse(s2[j]);
                        for(int p = j + 1; p < m; p++)
                        {
                            if(s[p] == '1')
                            {
                                hi += int.Parse(s2[p]);
                            }
                            if(s[p] == '0' && int.Parse(s2[p - 1]) <= hold)
                            {
                                hi += (hold - int.Parse(s2[p - 1]));
                                s[p - 1] = '0';
                                s[j] = '1';
                                j = p - 1;
                                break;
                            }
                            else if(p == m - 1 && int.Parse(s2[p]) <= hold)
                            {
                                hi += (hold - int.Parse(s2[p]));
                                j = m - 1;
                            }
                            else if (p == m - 1)
                            {
                                j = m - 1;
                            }
                        }
                    }
                }

                ans.Add(hi);

            }

            foreach (var it in ans)
                Console.WriteLine(it);

        }
    }
}
