using System;

namespace UserInput
{
    class Program
    {
        static void Main()
        {
            Console.Write("mass: ");
            double m = double.Parse(Console.ReadLine());

            Console.Write("acceleration: ");
            double a = double.Parse(Console.ReadLine());

            double f = m * a;
            Console.WriteLine($"Force = {f}");
        }
    }
}
