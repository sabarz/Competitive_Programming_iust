using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            Dictionary<Tuple<int, int>, int> d = new Dictionary<Tuple<int, int>, int>();
            List<string> ans = new List<string>();

            for(int i = 0; i < m; i ++)
            {
                s = Console.ReadLine().Split();
                d.Add(new Tuple<int, int>(int.Parse(s[0]) , int.Parse(s[1])) , 1);
                d.Add(new Tuple<int, int>(int.Parse(s[1]) , int.Parse(s[0])) , 1);
            }
            int q = int.Parse(Console.ReadLine());

            for(int i = 0; i < q; i ++)
            {
                s = Console.ReadLine().Split();
                if (d.ContainsKey(new Tuple<int, int>(int.Parse(s[0]) , int.Parse(s[1]))))
                    ans.Add("NO");
                else
                    ans.Add("YES");

            }

            foreach (var it in ans)
                Console.WriteLine(it);
        }
    }
}
