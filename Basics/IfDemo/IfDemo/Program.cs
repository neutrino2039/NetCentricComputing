using System;

namespace IfDemo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Principal: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Time: ");
            double t = double.Parse(Console.ReadLine());

            Console.Write("Account Type ");
            Console.Write("(Saving = S, Fixed = F): ");
            string type = Console.ReadLine().ToUpper();

            double r = 0.5;
            if (type == "S")
                r = 2.5;
            else if (type == "F")
                r = 7.0;

            double i = p * t * r / 100;
            Console.WriteLine($"Interest = ${i}");
        }
    }
}
