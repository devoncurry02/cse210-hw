class ReflectionActivity:Activity {
    private List<string> Prompts = new List<string> {"Think of a time when someone made your day.", "Think of a time you made someone else's day.", "Think of a time when you accomplished a difficult task."};
    private List<string> SubPrompts = new List<string> {"How did this make you feel?", "What do you wish would have gone differently?", "What did you learn from this experience?"};
    public ReflectionActivity():base("Reflection Activity", "Ponder past experiences to draw knowledge and strength.") {}
    
    public override void Perform() {
        Start();
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        Thread.Sleep(2000);
        Console.WriteLine(SubPrompts[random.Next(Prompts.Count)]);
        Thread.Sleep(_length * 1000 - 2000);
        End();
    }
}