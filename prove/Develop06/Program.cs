using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

class Program
{
    static Quests quests = new Quests();
    static int Loop = 1;
    static int keyA = 0;
    static int keyB = 0;
    static int keyC = 0;

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("                              ---------------\n                              |Eternal Quest|\n                              ---------------\n\n\n                        Press any key to continue...");
        Console.ReadKey();
        while(Loop == 1) {
            Console.Clear();
            Console.WriteLine("--------------\n|Goal Tracker|\n--------------------\n| - View Quests    |\n| - Achievements   |\n| - Stats     |\n|(type 'Q' to quit)|\n--------------------");
            string menuOption = Console.ReadLine();
            Console.Clear();
            if(menuOption.ToLower() == "view quests") {
                keyA = 1;
                quests.QuestsList();
            }
            else if(menuOption.ToLower() == "achievements") {
                keyB = 1;
                quests.DisplayAchievements(keyA, keyB, keyC);
            }
            else if(menuOption.ToLower() == "stats") {
                keyC = 1;
                quests.DisplayStats();
            }
            else if(menuOption.ToLower() == "q") {
                Loop = 0;
            }
        }

        Console.WriteLine("Thank you for playing Eternal Quest!\nExiting...");
        Thread.Sleep(2000);
    }
}