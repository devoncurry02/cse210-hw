using System;

class Program
{
    static void Main(string[] args) {
        List<Sport> sports = new List<Sport>();
        Running running = new Running("12/16/2024", 120, 6);
        sports.Add(running);
        Biking biking = new Biking("12/05/2024", 45, 12);
        sports.Add(biking);
        Swimming swimming = new Swimming("12/08/2024", 30, 55);
        sports.Add(swimming);

        foreach (Sport sport in sports)
        {
            Console.WriteLine(sport.Summary());
        }
    }
}