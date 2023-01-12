using System;

class Program
{
    static void Main(string[] args)
    {
       // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        int guess = -1;
        int guessCount = 0;
        
        
        // We could also use a do-while loop here...
            Console.WriteLine($"What is the magic number? ");
            magicNumber = int.Parse(Console.ReadLine());
        while (guess != magicNumber)
        {            
            Console.WriteLine($"What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            //The number of attempted will increase                                                     
            guessCount++;
            
            //Lower Number if the user will enter
            if (magicNumber > guess)
            {
                Console.WriteLine($"<Attempt:{guessCount}> HIGHER! ");
            
            }
            //else if the user Higher Number
            else if (magicNumber < guess)
            {
                
                Console.WriteLine($"<Attempt:{guessCount}> LOWER! ");
            }
            //If the user guess the number the Number he enter the system will show this Message
            else
            {
                Console.WriteLine($"You guessed it! Congratulations! Attempt:  {guessCount}");
            }
            
        }   
        
            string input;

            do
            {
                Console.Write("Do you want to continue? ");
                input = Console.ReadLine();
            } while (input == "yes");
            
    }    
}