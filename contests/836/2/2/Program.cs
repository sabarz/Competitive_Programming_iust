using System;

namespace _2
{
    class Program
    {
        public static bool bit_is_one(int x, int index)
        {
            return ((x >> index) & 1) == 1;
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; i ++)
            {
                int n = int.Parse(Console.ReadLine());
                int cnt = 1;
                while((1 << cnt) <= n)
                {
                    cnt++;
                }
                cnt--;
                int[,] numbers = new int[cnt, cnt];
                for (int j = 0; j < cnt; j ++)
                {
                    if (bit_is_one(n, j))
                    {

                    }
                }
            }
        }
    }
}
