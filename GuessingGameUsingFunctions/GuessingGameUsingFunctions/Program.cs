using System;

namespace GuessingGameUsingFunctions
{
    class Program
    {
        static void Main()
        {
            do
                StartNewGame();
            while (ConfirmReplay() == "Y");
        }

        private static string ConfirmReplay()
        {
            Console.Write("Replay (Y/N)? ");
            return Console.ReadLine().ToUpper();
        }

        private static void StartNewGame()
        {
            int randomNumber = GenerateRandomNumber();

            for (int i = 0; i <= 5; i++)
            {
                int guess = InputInt("guess: ");
                if (guess == randomNumber)
                {
                    Console.WriteLine("Hooray! You won.");
                    return;
                }
                else if (guess < randomNumber)
                    Console.WriteLine("Your guess is less than my number.");
                else
                    Console.WriteLine("Your guess is greater than my number.");
            }

            Console.WriteLine("Oh no! You lost.");
            Console.WriteLine($"The correct number is {randomNumber}");
        }

        private static int InputInt(string displayText)
        {
            Console.Write(displayText);
            return int.Parse(Console.ReadLine());
        }

        private static int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }
    }
}
