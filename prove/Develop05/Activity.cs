class Activity {
    private string _name;
    private string _description;
    private int _length;

    public Activity(string name, string description) {
        _name = name;
        _description = description;
    }

    public void Start() {
        Console.WriteLine($"\n{_name}\n{_description}\n\nHow long would you like to do this exercise? (seconds) ");
        _length = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("3");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("2");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("1");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Start!");
    }

    public void End() {
        Console.WriteLine("Well done. This Activity is complete.");
        Thread.Sleep(2000);
    }
}