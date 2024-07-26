using System;
using System.Collections;
using System.Collections.Generic;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> ans = new List<int>();

            for(int i = 0; i < n; i ++)
            {
                int m = int.Parse(Console.ReadLine());
                string[] numbers = Console.ReadLine().Split(' ');
                Dictionary<string, int> dic = new Dictionary<string, int>();

                for(int j = 0; j < numbers.Length; j ++)
                {
                    if (dic.ContainsKey(numbers[j]))
                        dic[numbers[j]]++;
                    else
                    {
                        dic.Add(numbers[j], 1);
                    }

                    if(dic[numbers[j]] >= 3)
                    {
                        ans.Add(int.Parse(numbers[j]));
                        break;
                    }
                }
                try
                {
                    if (ans[i] == 0)
                    {
                        ans[i] = -1;
                    }
                }
                catch
                {
                    ans.Add(-1);
                }
            }

            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
