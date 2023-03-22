using System;

public class Video
{
    public string _titleVideo;
    public string _author;
    public string _lenght;

    public List<Comments> _commentList = new List<Comments>();

    public void DisplayVideDetails()
    {
        Console.WriteLine($"Title: {_titleVideo}");
        Console.WriteLine($"Author: {_author}"); 
        Console.WriteLine($"Length: {_lenght} seconds");
        int commentCount = _commentList.Count();
        Console.WriteLine($"Comments({commentCount})");

        foreach(Comments comments in _commentList)
        {
            comments.DisplayComment();
        }

    }
}