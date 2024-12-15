class ReflectionActivity:Activity {
    private List<string> Prompts = new List<string> {"Think of a time when someone made your day.", "Think of a time you made someone else's day.", "Think of a time when you accomplished a difficult task."};
    private List<string> SubPrompts = new List<string>
    public ReflectionActivity():base("Reflection Activity", "Ponder past experiences.") {}
    
    public void Perform() {
        Start();
        
        End();
    }
}