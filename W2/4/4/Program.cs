using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> l = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int hold = int.Parse(s[2]);
                int cnt = 0, j = 1;


                while (j <= int.Parse(s[0]))
                {
                    if (j + hold - 1 <= int.Parse(s[0]))
                    {
                        cnt++;
                    }
                    j += 2 * hold - 1;
                }
                hold = int.Parse(s[3]);
                int cnt2 = 0;
                j = 1;
                while (j <= int.Parse(s[1]))
                {

                    if (j + hold - 1 <= int.Parse(s[1]))
                    {
                        cnt2++;
                    }
                    j += 2 * hold - 1;

                }

                l.Add(cnt * cnt2);
            }

            foreach (var it in l)
                Console.WriteLine(it);
        }
    }
}
