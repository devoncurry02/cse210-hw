using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Welcome to scripture memorizer! It's time to memorize the following scripture:\n");
        Scripture verse = new Scripture();

        bool exit = false;
        while (!exit) {
            Console.WriteLine($"Mosiah 18:8 - {verse.printVerse()}");
            Console.WriteLine("--Press enter to continue, or type 'quit' to end.--");
            string input = Console.ReadLine();
            Console.Clear();
            if (input == "quit") {
                Console.WriteLine("Terminating...");
                exit = true;
            }
            else {
                Random random = new Random();
                int[] randomInRange = new int[3];
                randomInRange[0] = random.Next(0, 53);
                randomInRange[1] = randomInRange[0];
                while (randomInRange[0] == randomInRange[1]) {
                    randomInRange[1] = random.Next(0, 53);
                }
                randomInRange[2] = randomInRange[0];
                while (randomInRange[2] == randomInRange[0]) {
                    randomInRange[2] = randomInRange[1];
                    while (randomInRange[2] == randomInRange[1]) {
                        randomInRange[2] = random.Next(0, 53);
                    }
                }
                
                string[] verseArray = verse.getVerseArray();
                replaceWord(verseArray, verseArray[randomInRange[0]]);
                replaceWord(verseArray, verseArray[randomInRange[1]]);
                replaceWord(verseArray, verseArray[randomInRange[2]]);
            }
        }
    }

    public static void replaceWord(string[] array, string wordToReplace) {
        for (int i = 0; i < array.Length; i++) {
            if (array[i] == wordToReplace) {
                array[i] = "____";
            }
        }
    }
}