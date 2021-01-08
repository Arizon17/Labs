using System;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            float average;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());          
            average = (a + b + c) / 3f;
            Console.WriteLine(average);
        }
    }
}
