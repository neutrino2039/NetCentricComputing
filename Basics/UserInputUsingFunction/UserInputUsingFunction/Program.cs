using System;

namespace UserInputUsingFunction
{
    class Program
    {
        static void Main()
        {
            double m = Input("mass: ");
            double a = Input("acceleration: ");
            Console.WriteLine($"Force = {Force(m, a)}");
        }

        private static double Force(double m, double a)
        {
            return m * a;
        }

        private static double Input(string displayText)
        {
            while (true)
            {
                Console.Write(displayText);
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine($"Please enter a real number");
                }
            }
        }
    }
}
