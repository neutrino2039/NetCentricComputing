using System;

namespace SumOfArray
{
    class Program
    {
        static void Main()
        {
            int[] data = { 5, 10, 15, 20, 25 };

            int sum = 0;
            for (int i = 0; i < data.Length; i++)
                sum += data[i];

            Console.WriteLine($"Sum = {sum}");
        }
    }
}
