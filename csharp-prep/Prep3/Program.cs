using System;
using System.Runtime.InteropServices;

class Program
{
    
    static void Main(string[] args)
    {
         
        
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 50);

        int guess = -1; 
        
        while (guess!= magic_number)
        {
            Console.WriteLine($"What is your guess? ");
            guess = int.Parse(Console.ReadLine());
    
            if (magic_number < guess)
        {
            Console.WriteLine($"Lower");
        }
            else if (magic_number > guess)
        {
            Console.WriteLine($"Higher");
        }
            else if (magic_number == guess)
        {
            Console.WriteLine($"That's correct!");
        }
            else
        {
            Console.WriteLine($"Please choose a number");
        }
        }
        
    }
}