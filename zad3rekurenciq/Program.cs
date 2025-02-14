using System;

namespace zad3rekurenciq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Reverse(n));
        }
        static int Reverse(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return (n % 10) * (int)Math.Pow(10, (int)Math.Log10(n)) + Reverse(n/ 10);
        } 
    }
}
