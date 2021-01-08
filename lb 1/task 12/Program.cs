using System;

namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());
            bool result = (n > 20) && (n % 2 == 1);
            Console.WriteLine(result);
        }
    }
}
