public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentList;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _commentList = [];
    }
    
    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }
    public int NumberComments()
    {   
        int i = 0;
        foreach (Comment comment in _commentList)
        {
            i++;
        }
        return i;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length(in seconds): {_length}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _commentList)
        {
            comment.DisplayInfo();
        }
        Console.WriteLine("");
    }
}