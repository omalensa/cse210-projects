public class Comment
{
    private string _commenterName;
    private string _text;

    // Constructor - runs when we create a new comment
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    // Returns the name of the person who commented
    public string GetCommenterName()
    {
        return _commenterName;
    }

    // Returns what the person wrote
    public string GetText()
    {
        return _text;
    }

    // Nice way to display the full comment
    public string GetDisplayText()
    {
        return _commenterName + ": " + _text;
    }
}