using System;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, n, nDigit;
            number = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            nDigit = number / (int)Math.Pow(10,n-1)% 10;
            Console.WriteLine(nDigit);
        }
    }
}
