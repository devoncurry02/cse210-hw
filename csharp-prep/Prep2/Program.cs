using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        float number = float.Parse(grade);
        string letter = "N/A";
        if (number >= 90) {
            letter = "A";
        }
        else if (number >= 80) {
            letter = "B";
        }
        else if (number >= 70) {
            letter = "C";
        }
        else if (number >= 60) {
            letter = "D";
        }
        else if (number < 60) {
            letter = "F";
        }
        else {
            Console.WriteLine("That is not a valid input, insert a number between 0 and 100");
        }
        Console.WriteLine($"Your letter grade is {letter}");
        if (number >= 70) {
            Console.Write("Congradulations, you passed the course!");
        }
        else {
            Console.Write("I'm sorry, you did not pass this course. Try again, you can do it!");
        }
    }
}