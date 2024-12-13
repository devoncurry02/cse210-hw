using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography.X509Certificates;

public class Quests {
    private int userScore = 0;
    private List<Quest> goals = new List<Quest>
    {
        new Quest("Daily Task", "Workout"),
        new Quest("Weekly Task", "Complete a coding project"),
        new Quest("Yearly Task", "Be Baptized")
    };

    public void QuestsList() {
        int innerLoop = 1;
        while (innerLoop == 1) {
            Console.WriteLine("\nYour Goals:");
            for (int i = 0; i < goals.Count; i++)
            {
                var goal = goals[i];
                Console.WriteLine($"{i + 1}. [{(goal.IsCompleted ? "X" : " ")}] {goal.Type}: {goal.Description}");
            }

            Console.WriteLine("\nType number of quest or type '0' to make a custom quest\n(Type 'Q' to exit)");
            string questOption = Console.ReadLine();
            if (questOption == "0") {
                Console.WriteLine("Type of quest (Daily, Weekly, Life):");
                string type = Console.ReadLine();
                type = type + " Task";
                Console.WriteLine("Description:");
                string description = Console.ReadLine();
                Console.Clear();
                goals.Add(new Quest(type, description));
            }
            else if (questOption.ToLower() == "q") {
                innerLoop = 0;
                Console.WriteLine("\nReturning to menu...");
                Thread.Sleep(1200);
                continue;
            }
            else {
                Console.Clear();
                if (int.TryParse(questOption, out int choice) && choice > 0 && choice <= goals.Count)
                {
                    var selectedGoal = goals[choice - 1];
                    selectedGoal.IsCompleted = true;
                    if (selectedGoal.Type == "Daily Task") {
                        userScore += 50;
                        Console.WriteLine($"\nYou completed '{selectedGoal.Description}'! You earned 50 points.");
                    }
                    else if (selectedGoal.Type == "Weekly Task") {
                        userScore += 200;
                        Console.WriteLine($"\nYou completed '{selectedGoal.Description}'! You earned 200 points.");
                    }
                    else if (selectedGoal.Type == "Yearly Task") {
                        userScore += 1000;
                        Console.WriteLine($"\nYou completed '{selectedGoal.Description}'! You earned 1000 points.");
                    }
                    else {
                        Console.WriteLine("That is not a valid input, returning...");
                        Console.Clear();
                    }
                }
            }
        }
    }

    public void DisplayStats() {
        Console.WriteLine($"\nYour Current Score: {userScore}");
        Thread.Sleep(2000);
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
    }
    public void DisplayAchievements(int keyA, int keyB, int keyC) {
        Console.WriteLine($"Achievements:\n");
        if (userScore >= 500) {
            Console.WriteLine(" X Begginer's Luck (Earn 500 total points)");
        }
        else {
            Console.WriteLine(" - Begginer's Luck (Earn 500 total points)");
        }
        if (userScore >= 4000) {
            Console.WriteLine(" X Now We're Getting Somewhere (Earn 4000 total points)");
        }
        else {
            Console.WriteLine(" - Now We're Getting Somewhere (Earn 4000 total points)");
        }
        if (userScore >= 25000) {
            Console.WriteLine(" X Overachiever (Earn 25000 total points)");
        }
        else {
            Console.WriteLine(" - Overachiever (Earn 25000 total points)");
        }
        if (keyA == 1 && keyB == 1 && keyC == 1) {
            Console.WriteLine(" X Experimenter (Try all main menu options)");
        }
        else {
            Console.WriteLine(" - Experimenter (Try all main menu options)");
        }
        Thread.Sleep(2000);
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
    }
}