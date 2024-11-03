using System;

class Program
{
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() {
        Console.WriteLine("What is your username? ");
        string uName = Console.ReadLine();
        return uName;
    }

    static int PromptUserNumber() {
        Console.WriteLine("What is your favorite number? ");
        string tempFavNum = Console.ReadLine();
        int favNum = int.Parse(tempFavNum);
        return favNum;
    }

    static int SquareNumber(int favNum) {
        int sqNum = favNum * favNum;
        return sqNum;
    }

    static void DisplayResult(string uName, int sqNum) {
        Console.WriteLine($"{uName}, the square of your number is {sqNum}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string uName = PromptUserName();
        int favNum = PromptUserNumber();
        int sqNum = SquareNumber(favNum);
        DisplayResult(uName, sqNum);
    }
}