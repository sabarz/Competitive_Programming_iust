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

            for (int i = 0; i < n ; i ++)
            {
                int m = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                int[] number = new int[m];
                bool CHECK = true;

                for (int j = 0; j < m; j++)
                {
                    number[j] = int.Parse(s[j]);
                }
                for (int j = 1; j < m; j++)
                {
                    if(number[j] < number[j - 1] && number[j - 1] % number[j] == 0 && j < m - 1 && number[j + 1] % number[j] == 0 && number[j + 1] > number[j])
                    {
                        ans.Add("NO");
                        CHECK = false;
                        break;
                    }
                }
                if(CHECK == true)
                {
                    ans.Add("YES");
                }
            }

            foreach(var it in ans)
            {
                Console.WriteLine(it);
            }
        }
    }
}
