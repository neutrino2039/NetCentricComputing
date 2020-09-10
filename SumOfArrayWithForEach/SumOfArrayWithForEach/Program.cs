using System;

namespace SumOfArrayWithForEach
{
    class Program
    {
        static void Main()
        {
            int[] data = { 5, 10, 15, 20, 25 };

            int sum = 0;
            foreach (int element in data)
                sum += element;

            Console.WriteLine($"Sum = {sum}");
        }
    }
}
