public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    // Add a comment to this video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Return how many comments this video has
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Display all information about the video
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Comments: {GetNumberOfComments()}");

        Console.WriteLine("Comments:");
        foreach (Comment c in _comments)
        {
            Console.WriteLine("   " + c.GetDisplayText());
        }

        Console.WriteLine("-----------------------------------");
    }
}