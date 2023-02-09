using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Win a Prize!");
        Console.Write("Choose a door:  1, 2, or 3: ");
        string userChoice = Console.ReadLine();
        
        if (userChoice == "Y")
        {
            string message = "You won a new computer!";
            Console.WriteLine(message);
        }
        else if (userChoice == "N" == false)
        {
            string message = "You won a new monitor!";
            Console.WriteLine(message);
        }
        else if (userChoice == "3")
        {
            string message = "You won a new keyboard!";
            Console.WriteLine(message);
        }
        else
        {
            string message = "You lose.  Better luck next time.";
            Console.WriteLine(message);
        }
        
        Console.ReadLine();

    }
       
}