using System;

namespace _3
{
    class Program
    {
        public static int binarySearch(long[] nums , long newNum , int[] dp , int LIS)
        {
            int l = -1, r = LIS - 1;
            while (r - l > 1)
            {
                int mid = l + (r - l) / 2;
                if (newNum <= nums[dp[mid]])
                {
                    r = mid;
                }
                else
                {
                    l = mid;
                }
            }

            return r;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            long[] nums = new long[n];
            int[] dp = new int[n + 1];

            for(int i = 0; i < n; i ++)
            {
                nums[i] = int.Parse(s[i]);
                dp[i] = 0;
            }

            int LIS = 1;
            for(int i = 1; i < n; i ++)
            {
                if(nums[i] < nums[dp[0]])
                {
                    dp[0] = i;
                }
                else if(nums[i] > nums[dp[LIS - 1]])
                {
                    dp[LIS] = i;
                    LIS++;
                }
                else
                {
                    int index = binarySearch(nums, nums[i], dp, LIS);
                    dp[index] = i;
                }
            }

            Console.WriteLine(LIS);

        }
    }
}
