using System;

namespace task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,k=0;
            string product;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            product =(Console.ReadLine());
            if  (a < 0)
            {
                k++;
            }
            if (b < 0)
            {
                k++;
            }
            if (c < 0)
            {
                k++;
            }
            if (k==1 || k==3)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }
        }
    }
}
