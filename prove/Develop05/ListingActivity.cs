using System.Diagnostics;

class ListingActivity:Activity {
    public ListingActivity():base("Listing Activity", "List things that make you happy.") {}
    private List<string> Prompts = new List<string> {"List things you're grateful for:", "List things you want to remember:", "List your favorite foods:"};
    
    public override void Perform() {
        Start();
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        List<string> items = new List<string>();
        DateTime timer = DateTime.Now.AddSeconds(_length);
        while (DateTime.Now < timer) {
            Console.Write(" - ");
            items.Add(Console.ReadLine());
        }
        Console.WriteLine($"{items.Count} items listed.");
        End();
    }
}