using System;
using System.Collections.Generic;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<int> ans = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                int[] num = new int[m];
                int answer = 0 , index = 0;

                for(int j = 0; j < m; j ++)
                {
                    num[j] = int.Parse(s[j]);
                    
                    if(num[j] < index + 1)
                    {
                        int hold = index;
                        answer += (hold * (hold + 1)) / 2;

                        if(index - j + 1!= j)
                        j = index - j;

                        index = 0;
                    }
                    if(j == m - 1)
                    {
                        int hold = index + 1;
                        answer += (hold * (hold + 1)) / 2;
                        
                        index = 0;
                    }
                    index++;
                }
                ans.Add(answer);
            }

            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
