using System;

namespace GuessingGameUsingFunctions
{
    class Program
    {
        static void Main()
        {
            do
                StartNewGame();
            while (UserWantsToReplay());
        }

        private static bool UserWantsToReplay()
        {
            Console.Write("Replay (Y/N)? ");
            return Console.ReadLine().ToUpper() == "Y";
        }

        private static void StartNewGame()
        {
            int randomNumber = GenerateRandomNumber();
            AskUserToGuess(randomNumber);
        }

        private static void AskUserToGuess(int randomNumber)
        {
            for (int i = 0; i <= 5; i++)
            {
                int guess = Input("guess: ");
                bool correctGuess = CheckGuess(guess, randomNumber);
                if (correctGuess) return;
            }

            ShowLostMessage(randomNumber);
        }

        private static bool CheckGuess(int guess, int randomNumber)
        {
            if (guess == randomNumber)
            {
                Console.WriteLine("Hooray! You won.");
                return true;
            }
            else if (guess < randomNumber)
                Console.WriteLine("Your guess is less than my number.");
            else
                Console.WriteLine("Your guess is greater than my number.");

            return false;
        }

        private static void ShowLostMessage(int randomNumber)
        {
            Console.WriteLine("Oh no! You lost.");
            Console.WriteLine($"The correct number is {randomNumber}");
        }

        private static int Input(string displayText)
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
