using System;

namespace task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine($"Максимальне значення {max}");
            
            
        }
    }
}
