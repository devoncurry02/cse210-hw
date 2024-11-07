using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        // House myHome = new House();
        // myHome._owner = "Devon Curry";

        // myHome._kitchen = new Blind();
        // myHome._kitchen._width = 60;
        // myHome._kitchen._height = 48;
        // myHome._kitchen._color = "white";

        // myHome._livingRoom = new Blind();
        // myHome._livingRoom._width = 72;
        // myHome._livingRoom._height = 52;
        // myHome._livingRoom._color = "white";

        Resume devon = new Resume();
        devon._name = "Devon Curry";

        devon._softwareEngineer = new Job();
        devon._softwareEngineer._title = "Software Engineer";
        devon._softwareEngineer._company = "Microsoft";
        devon._softwareEngineer._startyr = 2019;
        devon._softwareEngineer._endyr = 2022;

        devon._teamManager = new Job();
        devon._teamManager._title = "Team Manager";
        devon._teamManager._company = "Avan Gaurd";
        devon._teamManager._startyr = 2022;
        devon._teamManager._endyr = 2024;

        Console.WriteLine($"Name: {devon._name}\nJobs:\n  {devon._softwareEngineer._title}  ({devon._softwareEngineer._company})  {devon._softwareEngineer._startyr}-{devon._softwareEngineer._endyr}\n");
        Console.WriteLine($"  {devon._teamManager._title}  ({devon._teamManager._company})  {devon._teamManager._startyr}-{devon._teamManager._endyr}\n");
    }
}