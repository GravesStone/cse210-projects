using System;

public class Video
{
    public string _titleVideo;
    public string _author;
    public string _lenght;

    public List<Comments> _commentList = new List<Comments>();

    public void DisplayVideDetails()
    {
        Console.WriteLine();
        Console.WriteLine($"Title: {_titleVideo}");
        Console.WriteLine($"Author: {_author}"); 
        Console.WriteLine($"Length: {_lenght} ");
        Console.WriteLine();
        int commentCount = _commentList.Count();
        Console.WriteLine($"--------Comments({commentCount})--------");
        Console.WriteLine();

        foreach(Comments comments in _commentList)
        {
            comments.DisplayComment();
        }

    }
}