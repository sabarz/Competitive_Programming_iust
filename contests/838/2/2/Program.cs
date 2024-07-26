using System;
using System.Linq;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<List<Tuple<int, int>>> ans = new List<List<Tuple<int, int>>>();

            for(int i = 0; i < t; i ++)
            {
                int n = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split();
                List<Tuple<int , int>> a = new List<Tuple<int , int>>();
                for(int j = 0; j < n; j ++)
                {
                    a.Add(new Tuple<int, int>(int.Parse(s[j]) , j + 1));
                }
                List<Tuple<int, int>> hi = new List<Tuple<int, int>>();
                
                a = a.OrderBy(x => x.Item1).ToList();
                int hold = ((a[0].Item1 / 5) + 1) * 5 , maxx = hold;

                while(true)
                {
                    if(hold - a[0].Item1 > a[0].Item1)
                    {
                        hi.Add(new Tuple<int, int>(a[0].Item2, a[0].Item1));
                        int g = a[0].Item1, p = a[0].Item2;
                        a[0] = new Tuple<int, int>(g + g, p);
                    }
                    else
                    {
                        hi.Add(new Tuple<int, int>(a[0].Item2, hold - a[0].Item1));
                        break;
                    }    
                }

                for(int j = 1; j < n; j++)
                {
                    if(maxx == a[j].Item1)
                    {
                        continue;
                    }
                    else
                    {
                        hold = ((a[j].Item1 / maxx) + 1) * maxx;
                        while (true)
                        {
                            if (hold - a[j].Item1 > a[j].Item1)
                            {
                                hi.Add(new Tuple<int, int>(a[j].Item2, a[j].Item1));
                                int g = a[j].Item1 , p = a[j].Item2;
                                a[j] = new Tuple<int, int>(g + g, p);
                            }
                            else
                            {
                                hi.Add(new Tuple<int, int>(a[j].Item2, hold - a[j].Item1));
                                break;
                            }
                        }

                        maxx = hold;
                    }
                }

                ans.Add(hi); 
            }

            for(int i = 0; i < ans.Count; i ++)
            {
                int m = ans[i].Count;
                Console.WriteLine(m); 
                for(int j = 0; j < m; j++)
                {
                    Console.WriteLine(ans[i][j].Item1 + " " + ans[i][j].Item2); 
                }
            }
        }
    }
}
