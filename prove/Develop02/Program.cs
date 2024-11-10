using System;
using System.Reflection.Metadata;

class Program
{
    static List<Journal> entries = new List<Journal>();
    static Prompts promptsManager = new Prompts();
    static Random random = new Random();

    static void Main(string[] args)
    {
        bool menuExit = false;
        while (menuExit == false) {
            Console.WriteLine("--------------------\nSelect option:\n-1. Read Journal Entries\n-2. Write New Entry\n-3. Export Journal\n-4. Load Existing Journal\nType '0' to exit\n--------------------\nEnter a number: ");
            string menuString = Console.ReadLine();
            int menu = int.Parse(menuString);
            if (menu == 1) {
                displayAll();
            }
            else if (menu == 2) {
                newEntry();
            }
            else if (menu == 3) {
                export();
            }
            else if (menu == 4) {
                load();
            }
            else if (menu == 0) {
                Console.WriteLine("Are you sure you want to exit? (Unsaved changes will be lost.)\nType Yes or No: ");
                string exitConfirm = Console.ReadLine();
                if (exitConfirm == "Yes") {
                    menuExit = true;
                    Console.WriteLine("Exiting...");
                }
                else {
                    Console.WriteLine("Returning to menu...");
                }
            }
            else {
                Console.WriteLine("That is not a valid entry, try again or type '0' to exit.");
            }
        }
    }

    static string randomPrompt() {
        int index = random.Next(promptsManager.promptList.Count);
        return promptsManager.promptList[index];
    }

    static void newEntry() {
        Console.WriteLine("Adding New Journal Entry...\n");
        Console.WriteLine("1. Random Prompt\n2. Entry Without Prompt\nEnter number: ");
        string newChoices = Console.ReadLine();
        int newChoice = int.Parse(newChoices);
        Journal entry = new Journal();
        if (newChoice == 1) {
            entry._prompt = randomPrompt();
            Console.WriteLine("Prompt: " + entry._prompt);
        }
        else {
            entry._prompt = "N/A";
        }
        entry._date = DateTime.Now.ToString("yyyy-MM-dd");
        Console.WriteLine($"{entry._date} - ");
        entry._response = Console.ReadLine();
        entries.Add(entry);
        Console.WriteLine("Entry complete.\n");
    }

    static void displayAll() {
        foreach (Journal entry in entries) {
            if (entry._prompt == "N/A") {
                Console.WriteLine($"Date: {entry._date}\n-No Prompt-\nEntry: {entry._response}\n\n");
            }
            else {
                Console.WriteLine($"Date: {entry._date}\nPrompt: {entry._prompt}\nEntry: {entry._response}\n\n");
            }
        }
    }

    static void export() {
        string filePath = "JournalEntries.txt";
        using (StreamWriter written = new StreamWriter(filePath)) {
            foreach (Journal entry in entries) {
                written.WriteLine(entry._date);
                written.WriteLine(entry._prompt);
                written.WriteLine(entry._response);
            }
        }
        Console.WriteLine($"Succesfully saved to {filePath}\n");
    }

    static void load() {
        string filePath = "JournalEntries.txt";
        Journal entry = null;
        int lineCounter = 0;
        foreach (string line in File.ReadAllLines(filePath)) {
            if (lineCounter % 3 == 0) {
                entry = new Journal();
                entry._date = line.Trim();
            }
            else if (lineCounter % 3 == 1) {
                entry._prompt = line.Trim();
            }
            else if (lineCounter % 3 == 2) {
                entry._response = line.Trim();
                entries.Add(entry);
            }
            lineCounter++;
        }
        Console.WriteLine("File succesfully loaded.\n");
    }
}