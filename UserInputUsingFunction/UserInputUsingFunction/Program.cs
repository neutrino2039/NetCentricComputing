using System;

namespace UserInputUsingFunction
{
    class Program
    {
        static void Main()
        {
            double m = InputDouble("mass: ");
            double a = InputDouble("acceleration: ");

            double f = m * a;
            Console.WriteLine($"Force = {f}");
        }

        private static double InputDouble(string displayText)
        {
            Console.Write(displayText);
            return double.Parse(Console.ReadLine());
        }
    }
}
