using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers =  new List<int>();

        int unumber = -1;

        while (unumber != 0)
        {
            Console.WriteLine("Please enter a set of numbers. Type 0 when finished.");
            string uresponse = Console.ReadLine();
            unumber = int.Parse(uresponse);
            
            if (unumber != 0)
            {
                numbers.Add(unumber);
            }
        }   
      //This computes the sum of the list. It iterates through list "numbers" that we declared at the top. Notice how it recognizes "number"
      //to be a single item in the list.  
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Your sum is: {sum}");


    //This computes average. Notice the syntax of converting "sum" to a float type. Then I can get list length using .Count.
        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        
        int max = numbers[0];

        foreach (int number in numbers)
        {   if (number > max)
            {
                max = number;
            }    
        }

        Console.WriteLine($"The max is {max}");
    }
}