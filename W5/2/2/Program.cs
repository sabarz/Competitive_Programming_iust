using System;

namespace _2
{
    class Program
    {
        public static long N = (long)Math.Pow(10, 9) + 7;
        public static long fact(long x)
        {
            long ans = 1;
            for (int i = 1; i <= x; i++)
            {
                ans *= i;
                ans %= N;
            }
            return ans;
        }

        public static long pow(long x , long y)
        {
            long ans = 1;
            while(y > 0)
            {
                if(y % 2 == 1)
                {
                    ans *= x;
                    ans %= N;
                    y--;
                }
                else
                {
                    x *= x;
                    x %= N;
                    y /= 2;
                }
            }

            return ans;
        }
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            long n = int.Parse(s[0]);
            long m = int.Parse(s[1]);
            long ans = (((fact(2 * m + n - 1) * pow(fact(2 * m), N - 2)) % N) * pow(fact(n - 1), N - 2)) % N;
            Console.WriteLine(ans);
        }
    }
}
