using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool play = true;
        while (play == true) {
            Random randomGenerator = new Random();
            int theNumber = randomGenerator.Next(1, 100);
            bool end = false;
            while (end == false) {
                Console.WriteLine("What is your guess? ");
                string var = Console.ReadLine();
                int guess = int.Parse(var);
                if (guess == theNumber) {
                    end = true;
                    Console.WriteLine("You guessed it!");
                }
                else if (guess >= theNumber) {
                    Console.WriteLine("Lower");
                }
                else if (guess <= theNumber) {
                    Console.WriteLine("Higher");
                }
                else {
                    Console.Write("ERROR");
                }
            }
            Console.Write("Would you like to play again? Y/N ");
            string gameAgain = Console.ReadLine();
            if (gameAgain == "Y") {
                continue;
            }
            else {
                play = false;
            }
        }
    }
}