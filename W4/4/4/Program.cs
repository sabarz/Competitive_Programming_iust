using System;

namespace _4
{
    class Program
    {
        public static int turn_zero(int x, int index)
        {
            return ~(1 << index) & x;
        }
        public static int turn_one(int x, int index)
        {
            return (1 << index) | x;
        }
        public static bool bit_is_one(int x, int index)
        {
            return ((x >> index) & 1) == 1;
        }
        public static int number_one(int x, int n)
        {
            int cnt = 0;
            for (int i = 0; i < n; i++)
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
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            int k = int.Parse(s[2]);
            int[] nums = new int[n];
            long[,] dp = new long[n, (int)Math.Pow(2, n)];
            int[,] satisfaction = new int[n, n];
            s = Console.ReadLine().Split(' ');
            
            for(int i = 0; i < n; i ++)
            {
                nums[i] = int.Parse(s[i]);
            }

            for(int i = 0; i < k; i ++)
            {
                s = Console.ReadLine().Split(' ');
                satisfaction[int.Parse(s[0]) - 1, int.Parse(s[1]) - 1] = int.Parse(s[2]);
            }
            long ans = -1;
            for (int i = 0; i < n; i ++)
            {
                dp[i, (1 << i)] = nums[i];
                ans = Math.Max(ans, nums[i]);
               /* for(int j = 0; j < n; j ++)
                {
                    if(j != i)
                        dp[j, (1 << i)] = -1;
                }*/
            }
            for (int i = 0; i < Math.Pow(2, n); i++)
            {
                if (number_one(i, n) != 1 && number_one(i, n) != 0)
                {
                    for(int j = 0; j < n; j ++)
                    {
                        if(!bit_is_one(i , j))
                        {
                            dp[j, i] = 0;
                        }
                        else
                        {
                            long maxxx = -1;
                            int hold = turn_zero(i, j);

                            for (int p = 0; p < n; p++)
                            {
                                if(bit_is_one(i , p))
                                    maxxx = Math.Max(maxxx, dp[p, hold] + satisfaction[p , j] + nums[j]);
                            }

                            dp[j, i] = maxxx;
                            if(number_one(i , n) == m)
                            {
                                ans = Math.Max(ans, maxxx);
                            }
                        }
                    }
                }      
            }

            Console.WriteLine(ans);
        }
    }
}
