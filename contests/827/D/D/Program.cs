using System;
using System.Collections.Generic;

namespace D
{
    class Program
    {
        static int GCD(int num1, int num2)
        {
            int Remainder;

            while (num2 != 0)
            {
                Remainder = num1 % num2;
                num1 = num2;
                num2 = Remainder;
            }

            return num1;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> ans = new List<int>();

            for(int i = 0; i < n; i ++)
            {
                int m = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                int answer = -1;
                for(int k = m - 1; k >= 0; k --)
                {
                    for(int p = k ; p >= 0; p--)
                    {
                        if(GCD(int.Parse(s[k]) , int.Parse(s[p])) == 1)
                        {
                            answer = Math.Max(answer, k + p + 2);
                        }
                    }
                }
                ans.Add(answer);
            }
            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
