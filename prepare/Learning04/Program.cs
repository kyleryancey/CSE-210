using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment A1 = new Assignment("Kyler Yancey", "Multiplication");
        Console.WriteLine(A1.GetSummary());

        // Now create the derived class assignments
        MathAssignment A2 = new MathAssignment("Karlee Yancey", "Fractions", "7.3", "8-19");
        Console.WriteLine(A2.GetSummary());
        Console.WriteLine(A2.GetHomeworkList());

        WritingAssignment A3 = new WritingAssignment("Jake Thueson", "European History", "The Causes of World War II");
        Console.WriteLine(A3.GetSummary());
        Console.WriteLine(A3.GetWritingInformation());
    }
}