using System;
using System.Collections.Generic;

namespace A
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
                int[] num = new int[m];
                for(int j = 0; j < m; j ++)
                {
                    num[j] = int.Parse(s[j]);
                }

                int hold = num[0];
                for(int j = 1; j < m; j ++)
                {
                    hold = GCD(hold, num[j]);
                }
                
                if(hold == 1)
                {
                    ans.Add(0);
                }
                else if(GCD(hold ,m) == 1)
                {
                    ans.Add(1);
                }
                else if(GCD(hold ,m - 1) == 1)
                {
                    ans.Add(2);
                }
                else
                {
                    ans.Add(3);
                }
            }

            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
