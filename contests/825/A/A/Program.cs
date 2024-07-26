using System;
using System.Collections.Generic;

namespace A
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
                string[] a = Console.ReadLine().Split(' ');
                string[] b = Console.ReadLine().Split(' ');
                int different = 0 , oneA = 0 , oneB = 0;

                for(int j = 0; j < m; j ++)
                {
                    if(a[j] != b[j])
                    {
                        different++;
                    }
                    if(a[j] == "1")
                    {
                        oneA++;
                    }
                    if(b[j] == "1")
                    {
                        oneB++;
                    }
                }

                int hold = Math.Abs(oneA - oneB);
                if(different > hold)
                {
                    ans.Add(hold + 1);
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