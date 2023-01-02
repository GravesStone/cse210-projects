using System;

class Program
{
    static void Main(string[] args)
    {
    // User Input
       Console.WriteLine("Welcome to BYU Calculator Grade");
       Console.WriteLine("What is the grade percentage? ");
       string answer = Console.ReadLine();
    // Typing in the Screen
       int percentage = int.Parse(answer);
    // Declaire A Integer + Connect in the Answer that the user inputed in Answer
        string letter = "";
    //If else Method 
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        //If the user doesn't meet the requirments on the grade it will automatically Shows F
        else
        {
            letter = "F";
        }

        Console.WriteLine($" Your  Grade is {letter}");
        //End Of the Code Result if Greater than 90-60
        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        // Else if the user has a lower than User < 69 the Program show Better Luck Next time 
        else
        {
            Console.WriteLine($"Better luck next time Need to improve!! , {letter}");
        }
    }
}