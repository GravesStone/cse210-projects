using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();
 
        Console.WriteLine("-----Youtube-----");
        
        //Video
        //Glock9
        Video glock9 = new Video();
        glock9._titleVideo = "Yugyugan";
        glock9._lenght = "5:03";
        glock9._author = "Glock 9 ";
        
        
        
        //CommentsG9
        Comments glock09Comment1 = new Comments();
        glock09Comment1._YoutubeUser = "Jay asin";
        glock09Comment1._commentTxt = "Your song is good!.";

        Comments glock09Comment2 = new Comments();
        glock09Comment2._YoutubeUser = "Gshocck";
        glock09Comment2._commentTxt = "Your song is Dope.";

        Comments glock09Comment3 = new Comments();
        glock09Comment3._YoutubeUser = "Lily";
        glock09Comment3._commentTxt = "The song wasn't good it ralks about drugs.";

     
        //----------------------------

        //Imagine Dragons
        Video Imad = new Video();
        Imad._titleVideo = "Believer";
        Imad._lenght = "5:03";
        Imad._author = "Imagine Dragons ";

        //CommentsID
        Comments IDComment1 = new Comments();
        IDComment1._YoutubeUser = "Jayson";
        IDComment1._commentTxt = "Let's Rock!!! .";

        Comments IDComment2 = new Comments();
        IDComment2._YoutubeUser = "Peter";
        IDComment2._commentTxt = "That song was inspiring!!!.";

        Comments IDComment3 = new Comments();
        IDComment3._YoutubeUser = "JayJay";
        IDComment3._commentTxt = "The song wasn't good it ralks about drugs.";

        



        //Declaration

        //Video Declaration
        videosList.Add(glock9);
        //Comment Declaration
        glock9._commentList.Add(glock09Comment1);
        glock9._commentList.Add(glock09Comment2);
        glock9._commentList.Add(glock09Comment3);
        //Line Declaration

        //--------------------

        //Imagine Dragonn
        
        videosList.Add(Imad);
        //Comment Declaration
        Imad._commentList.Add(IDComment1);
        Imad._commentList.Add(IDComment2);
        Imad._commentList.Add(IDComment3);
        
        //Line Declaration ID
        
        
       
        foreach (Video video in videosList)
        {
            video.DisplayVideDetails();
        }
        
    }
}