using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<string> ans = new List<string>();

            for(int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split();
                int[] a = new int[n];

                for(int j = 0; j < n; j ++)
                {
                    a[j] = int.Parse(s[j]);
                }
            }
        }
    }
}
