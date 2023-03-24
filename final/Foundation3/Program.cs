using System;

class Program
{
    static void Main(string[] args)
    {
        //Column 1
        Address address1 = new Address ("Tandang Sora", "Metro Manila", "Quezon City", "1990-365", "Philippines");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Stake Conference", "Church meeting with Elder Wakolo.", "June,20 2019", "10:00 am - 12:00 pm", $"{lectureAddress}", "Lecture", "Elder Rice", 400);

        //Information Lecture
        Console.WriteLine("--------------------------Information---------------------------------------------");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();


        Address address2 = new Address ("Manila Temple", "White Plains", "Quezon City", "1107-224", "Philippines");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Mark and Patricia", "Mark and Patricia's wedding ceremony and reception", "July 2, 2024", "4:00 pm - 12:00am", $"{receptionAddress}", "Reception", "MarkE@gmail.com");
        //display reception event details
        Console.WriteLine("------------------------------------Venue----------------------------------");
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();


        Address address3 = new Address ("Quezon City Stake", "Manila", "QC", "43017", "Philppines");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Sport Fest YM & YW", "Sports in the summer activity.", "February 10, 2023", "8:00Am - 12:00nn", $"{outdoorAddress}", "Outdoor", "Sunny");
        //display outdoor event details
        Console.WriteLine("---------------------------------------------------------------------------");
        
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
        Console.WriteLine("---------------------------------------------------------------------------");
        
    }
}