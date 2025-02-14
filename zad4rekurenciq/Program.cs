namespace zad4rekurenciq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(num, pow));
        }
        static int Power(int num, int pow) 
        {
            if (pow == 0)
            {
                return 1;
            }
            return num * Power(num, pow - 1);
        }
    }
}
