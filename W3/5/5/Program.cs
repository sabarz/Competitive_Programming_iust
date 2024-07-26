using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            s = Console.ReadLine().Split(' ');
            int[] nums = new int[n];
            long[,,] dp = new long[n, b+1, 2];

            for(int i = 0; i < n; i ++)
            {
                nums[i] = int.Parse(s[i]);
                for(int j = 0; j <= b; j ++)
                {
                    dp[i, j, 0] = (long)Math.Pow(10 , 14); 
                    dp[i, j, 1] = (long)Math.Pow(10 , 14); 
                }
            }
            dp[0, 0, 1] = 0;
            dp[0, 1, 0] = 0;

            for(int i = 1; i < n; i ++)
            {
                for(int j = 0; j <= b; j ++)
                {
                    if(i - j < b)
                        dp[i, j, 1] = Math.Min(dp[i - 1, j, 1], dp[i - 1, j, 0] + nums[i]);

                    if(j > 0)
                        dp[i, j, 0] = Math.Min(dp[i - 1, j - 1, 0], dp[i - 1, j - 1, 1] + nums[i]);
                    //dp[i, j, 0] = long.MaxValue;
                    //dp[i, j, 1] = long.MaxValue;
                }
            }

            long ans = long.MaxValue;
            for(int i = 0; i <= b; i ++)
            {
                ans = Math.Min(ans, Math.Min(dp[n - 1, i, 0], dp[n - 1, i, 1]));
            }

            Console.WriteLine(ans);
        }
    }
}
