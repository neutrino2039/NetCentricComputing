using System;

namespace SwitchDemo
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

            double r = type switch
            {
                "S" => 2.5,
                "F" => 7.0,
                _ => 0.5,
            };

            double i = p * t * r / 100;
            Console.WriteLine($"Interest = {i}");
        }
    }
}
