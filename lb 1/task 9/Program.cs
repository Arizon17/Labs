using System;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, h;
            float area;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            h = float.Parse(Console.ReadLine());
            area = (a + b) / 2f*h;
            Console.WriteLine(area);
            
        }
    }
}
