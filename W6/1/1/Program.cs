using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            Console.WriteLine((n * (n - 1)) / 2);
        }
    }
}
