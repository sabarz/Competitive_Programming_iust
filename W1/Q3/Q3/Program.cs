using System;
using System.Collections.Generic;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i ++)
            {
                int m = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                int[] numbers = new int[m];
                int cnt = 0;
                bool check = true;
                
                foreach(string it in s)
                {
                    numbers[cnt++] = int.Parse(it);
                }
                for(int j = 2; j < m; j += 2)
                {
                    if (numbers[j] % 2 != numbers[j - 2] % 2)
                    {
                        check = false;
                        break;
                    }
                }
                for(int j = 3; j < m; j += 2)
                {
                    if(j != 0 && numbers[j] % 2 != numbers[j - 2] % 2)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

            }
        }
    }
}
