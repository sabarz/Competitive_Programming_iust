using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            int[,] hi = new int[n, n];

            for(int i = 0; i < m; i ++)
            {
                s = Console.ReadLine().Split();
                hi[int.Parse(s[0]) - 1, int.Parse(s[1]) - 1] = 1;
                hi[int.Parse(s[1]) - 1 ,int.Parse(s[0]) - 1] = 1;
            }

            for(int i = 0; i < n; i ++)
            {
                for(int j = 0; j < n; j ++)
                {
                    Console.Write(hi[i, j]); 
                }
                Console.WriteLine();
            }
        }
    }
}
