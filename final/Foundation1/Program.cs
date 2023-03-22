using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----Youtube-----");
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._titleVideo = "";
        video1._lenght = "162";
        video1._author = "Glock 9 ";

        Comments video1Comment1 = new Comments();
        video1Comment1._YoutubeUser = "Jay asin";
        video1Comment1._commentTxt = "Your song is good!.";
        video1._commentList.Add(video1Comment1);
        videosList.Add(video1);
       
        foreach (Video video in videosList)
        {
            Console.WriteLine("---------");
            video.DisplayVideDetails();
            Console.WriteLine();
        }
    }
}