class Quest
{
    public string Type {get;}
    public string Description {get;}
    public bool IsCompleted {get; set;}

    public Quest(string type, string description)
    {
        Type = type;
        Description = description;
        IsCompleted = false;
    }
}
