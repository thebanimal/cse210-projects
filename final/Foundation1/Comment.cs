public class Comment
{
    private string _user;
    private string _text;

    public Comment(string user, string text)
    {
        _user = user;
        _text = text;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"  User: {_user}");
        Console.WriteLine($"  Comment: {_text}");
    }
}