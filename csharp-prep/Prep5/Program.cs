using System;

class Program
{
    static void Main(string[] args)
    {
            DisplayWelcomeMessage();

            string NameX = PromptUserName();
            int NumberY = PromptUserNumber();

            int NumS = SquareNumber(NumberY);

            DisplayResult(NameX, NumS);
        }

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your Full Name: ");
            string name = Console.ReadLine();

            return name;
        }
        

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}: (Answer) square of your number is {square}");
        }
    
}