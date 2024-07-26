using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            string[] s1 = Console.ReadLine().Split(' ');
            string[] s2 = Console.ReadLine().Split(' ');
            long[,] dp = new long[k, 3];
            int[] q1 = new int[k];
            int[] q2 = new int[k];
           
            for(int i = 0; i < k; i ++)
            {
                q1[i] = int.Parse(s1[i]);
                q2[i] = int.Parse(s2[i]);
            }

            dp[0, 0] = q1[0];  
            dp[0, 1] = 0;  
            dp[0, 2] = q2[0];  
            for(int i = 1; i < k; i ++)
            {
                dp[i, 0] = Math.Max(dp[i - 1 , 1], dp[i - 1 , 2]) + q1[i];
                dp[i, 1] = Math.Max(Math.Max(dp[i - 1, 0], dp[i - 1 , 1]), dp[i - 1 , 2]);
                dp[i, 2] = Math.Max(dp[i - 1 , 0], dp[i - 1 , 1]) + q2[i];
            }

            Console.WriteLine(Math.Max(Math.Max(dp[k - 1 , 0], dp[k - 1 , 1]), dp[k - 1 , 2])) ;
        }
    }
}
