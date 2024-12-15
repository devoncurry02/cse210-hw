using System.Drawing;

public class Video {
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;
    
    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void WriteComment(Comment soloComment) {
        _comments.Add(soloComment);
    }

    public void PrintInfo() {
        Console.WriteLine($"\n\nTitle - {_title}");
        Console.WriteLine($"Author - {_author}");
        Console.WriteLine($"Length - {_length}s");
        Console.WriteLine($"\nComments:");
        foreach (var comment in _comments) {
            Console.WriteLine(comment.PrintComment());
        }
    }
}