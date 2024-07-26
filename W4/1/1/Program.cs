using System;

namespace _1
{
    class Program
    {
        public static int turn_zero(int x , int index)
        {
            return ~(1 << index) & x;
        }
        public static int turn_one(int x , int index)
        {
            return (1 << index) | x;
        }
        public static bool bit_is_one(int x , int index)
        {
            return ((x >> index) & 1) == 1;
        }
        public static int number_one(int x , int n)
        {
            int cnt = 0;
            for(int i = 0; i < n; i++)
            {
                if (bit_is_one(x, i))
                {
                    cnt++;
                }
            }
            return cnt;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[,] a = new double[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j ++)
                {
                    a[i, j] = double.Parse(s[j]);
                }
            }
            double[] dp = new double[(int)Math.Pow(2, n)];
            dp[(int)Math.Pow(2, n) - 1] = 1;
            
            for(int mask = (int)Math.Pow(2 , n) - 1; mask > 0; mask--)
            {
                double ones = number_one(mask, n);
                for(int i = 0; i < n; i ++)
                {
                    if (bit_is_one(mask, i))
                    {
                        for(int j = 0; j < n; j ++)
                        {
                            if(j != i && bit_is_one(mask , j))
                            {
                                dp[turn_zero(mask, j)] += dp[mask] * a[i, j] / (double)(ones * (ones - 1) / 2);
                            }
                        }
                    }
                }
            }
           
            for(int i = 0; i < n; i ++)
            {
                Console.Write(dp[turn_one(0, i)].ToString("N6") + " ");
            }

        }
    }
}
