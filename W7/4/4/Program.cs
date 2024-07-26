
using System;

namespace _4
{
    class Program
    {
        public static long power(long x , int y)
        {
            long e = (long)Math.Pow(10, 9) + 7;
            long ans = 1;
            for(int i = 0; i < y; i++)
            {
                ans *= x;
                ans %= e;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            int k = int.Parse(s[2]);

            int t;
            if(k == 1 || n < k)
                t = n;
            else if(n == k)
                t = (n + 1) / 2;
            else 
                t = 1 + k % 2;

            Console.WriteLine(power(m, t));
        }
    }
}
