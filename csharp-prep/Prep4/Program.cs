using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        // Please note we could use a do-while loop here instead
        int userNum = -1;
        while (userNum != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNum = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Compute the average
      
        float aver = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {aver}");

        // Part 3: Find the max Value
    
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}