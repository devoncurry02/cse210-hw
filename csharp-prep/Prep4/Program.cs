using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input a series of numbers (type '0' to stop)");
        List<int> numbers = new List<int>();
        int exit = 0;
        while (exit == 0) {
            Console.WriteLine("Enter a number");
            string inp = Console.ReadLine();
            int input = int.Parse(inp);
            if (input == 0) {
                exit = 1;
            }
            else {
                numbers.Add(input);
            }
        }
        int sum = 0;
        int lrgnum = 0;
        foreach (int number in numbers) {
            sum += number;
            if (lrgnum < number) {
                lrgnum = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}\nThe average is: {sum / numbers.Count}\nThe largest number is: {lrgnum}\n");
    }
}