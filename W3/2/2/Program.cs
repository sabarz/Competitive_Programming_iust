using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int[] dp = new int[s.Length + 1];
            int cnt = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if(char.IsUpper(s[i]))
                {
                    cnt++;
                }
            }
            dp[0] = cnt;
            int ans = cnt;
            for(int i = 0; i < s.Length; i++)
            {
                if(char.IsUpper(s[i]))
                {
                    dp[i + 1] = dp[i] - 1;
                }
                else
                {
                    dp[i + 1] = dp[i] + 1;
                }
                ans = Math.Min(ans, dp[i + 1]);
            }

            Console.WriteLine(ans);
        }
    }
}
