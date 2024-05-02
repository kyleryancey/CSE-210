using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
       string Uname = PromptUserName();
        int Unumber =  PromptUserNumber();
        int SquareNum = SquareNumber(Unumber);
        DisplayResult(Uname, SquareNum );
 
    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello");

        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?: ");
        int number = int.Parse(Console.ReadLine());

        return number;
        
    }

    static int SquareNumber(int number)
    {
        int SqNum = number * number;
        //Console.WriteLine($"The square of your favorite number is: {SqNum}");
        return SqNum;
    }

    static void DisplayResult(string name, int SqNum)
    {
        Console.WriteLine($"{name}, the square of your number is: {SqNum}");
    }


}