using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your First name? ");
        string first = Console.ReadLine();
      
        Console.WriteLine("What is your surname ? ");
        string second = Console.ReadLine();
        Console.WriteLine("Your Fullname is " + second + "," +  first);
    }
}