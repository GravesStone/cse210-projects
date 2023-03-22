using System;

public class Comments
{
    public string _YoutubeUser;
    public string _commentTxt;

    public void DisplayComment()
    {
        Console.WriteLine($" {_YoutubeUser}: {_commentTxt}");
        Console.WriteLine("---------------------------");
    }
}