using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Fraction devon = new Fraction();
        devon.SetTop(5);
        devon.SetBottom(22);
        Console.WriteLine($"Default Fraction: {devon.GetFractionString()}");
        Console.WriteLine($"Default Fraction: {devon.GetDecimalValue()}");
    }
}