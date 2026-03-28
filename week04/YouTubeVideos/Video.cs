using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }

    private int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} by {_author}, Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");

        foreach (Comment comment in _comments)
        {
            comment.DisplayText();
        }
        Console.WriteLine();
    }
}
