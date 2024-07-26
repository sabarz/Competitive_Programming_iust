using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            s = Console.ReadLine().Split(' ');
            long[,] dp = new long[k , k];
            int[] nums = new int[k];
            int[] hi = new int[k];

            for(int i = 0; i < k; i ++)
            {
                nums[i] = int.Parse(s[i]);
            }
            hi[0] = nums[0];
            for(int i = 1; i < k; i ++)
            {
                hi[i] = hi[i - 1] + nums[i];
            }
            for (int i = 1; i < k; i ++)
            {
                int cnt = 0, t = 0, p = i;
                for(int j = i; j < k; j ++)
                {
                    long min = long.MaxValue;

                    for(int x = 0;x < p - t ; x ++)
                    {
                        min = Math.Min(min, dp[cnt + t, cnt + t + x] + dp[cnt + t + x + 1, cnt + p]);
                    }
                    if(cnt + t - 1 == -1)
                    {
                        dp[cnt + t, cnt + p] = min + hi[cnt + p] ;
                    }
                    else
                        dp[cnt + t, cnt + p] = min + hi[cnt + p] - hi[cnt + t - 1];
                    cnt++;
                }
            }

            Console.WriteLine(dp[0, k - 1]);
        }
    }
}
