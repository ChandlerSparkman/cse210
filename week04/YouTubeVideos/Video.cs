public class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string commenterName, string commentContent)
    {
        Comment comment = new Comment(commenterName, commentContent);

        _comments.Add(comment);
    }

    public int GetCommentNum()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"{_title}\nUploaded by: {_author}\n{_length} seconds\n");
        Console.WriteLine($"Comments({GetCommentNum()})\n");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetDisplayText());
        }
    }
}