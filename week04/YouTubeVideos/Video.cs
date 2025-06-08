using System;
using System.Collections.Generic;

public class Video
{
    public string Title {get; set;}
    public string Author {get; set;}
    public int Length {get; set;}

    private List<Comment> _comments =new List<Comment>();

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Comment: {GetCommentCount()}");

        foreach(Comment comment in _comments)
        Console.WriteLine($"-{comment.CommenterName} : {comment.Text}");

        Console.WriteLine();
    }
}