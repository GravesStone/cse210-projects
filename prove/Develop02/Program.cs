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
        //A 100%–93%
        if (percentage >= 100)
        {
            letter = "A";
        }
        if (percentage >= 93)
        {
            letter = "A";
        }
        //A- 92%–90%
        else if (percentage >=92)
        {
            letter = "A-";
        }
        else if (percentage >=90)
        {
            letter = "A-";
        }
        //B+ 89%–87%
        else if (percentage >= 89)
        {
            letter = "B+";
        }
        else if (percentage >= 87)
        {
            letter = "B+";
        }
        //B 86%–83%
        else if (percentage >= 86)
        {
            letter = "B";
        }
        else if (percentage >= 83)
        {
            letter = "B";
        }
        //B- 82%–80%
        else if (percentage >= 82)
        {
            letter = "B-";
        }
         else if (percentage >= 80)
        {
            letter = "B-";
        }
        //C+ 79%–77%
        else if (percentage >= 79)
        {
            letter = "C+";
        }
        else if (percentage >= 77)
        {
            letter = "C+";
        }
        //C 76%–73%
        else if (percentage >= 76)
        {
            letter = "C";
        }
         else if (percentage >= 73)
        {
            letter = "C";
        }
        //C-	72%–70%
        else if (percentage >= 72)
        {
            letter = "C-";
        }
        else if (percentage >= 70)
        {
            letter = "C-";
        }
        //D+	69%–67%
        else if (percentage >= 69)
        {
            letter = "D+";
        }
        else if (percentage >= 67)
        {
            letter = "D+";
        }
        // D	66%–63%
        else if (percentage >= 66)
        {
            letter = "D";
        }
        else if (percentage >= 63)
        {
            letter = "D";
        }
        // D-	62%–60%
        else if (percentage >= 62)
        {
            letter = "D-";
        }
        //If the user doesn't meet the requirments on the grade it will automatically Shows F
        else if (percentage >= 60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($" Your  Grade is {letter}");
        //End Of the Code Result if Greater than 90-60
        if (percentage >= 60)
        {
            Console.WriteLine("You passed!");
        }
        // Else if the user has a lower than User < 69 the Program show Better Luck Next time 
        else
        {
            Console.WriteLine($"Better luck next time Need to improve!! ,Grade: {letter}");
        }
    }
}