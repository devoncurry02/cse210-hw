using System;
using System.Collections;

class Program
{
    private Activity[] activities;
    public Program() {
        activities = new Activity[]
        {
            new BreathingActivity(),
            new ListingActivity(),
            new ReflectionActivity()
        };
    }
    static void Main(string[] args) {
        Program program = new Program();
        program.Play();
    }
    public void Play() {
        while (true)
        {
            Console.WriteLine("\nChoose an activity:\n1. Breathing\n2. Listing\n3. Reflection\n4. Exit\n");
            Console.Write("Enter choice (number): ");
            string Choice = Console.ReadLine();
            int choice = int.Parse(Choice);
            if (choice >= 1 && choice <= activities.Length)
            {
                Activity execute = activities[choice-1];
                execute.Perform();
            }
            else if (choice == 4) {
                Console.WriteLine("Exiting...");
                Thread.Sleep(2000);
                Console.Clear();
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid input, please try again.");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}