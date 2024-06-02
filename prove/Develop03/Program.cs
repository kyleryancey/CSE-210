using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("John", 3, 16);
        var scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        var scripture = new Scripture(reference, scriptureText);

        Console.WriteLine(scripture);

        while (!scripture.AllWordsHidden())
        {
            Console.ReadLine();
            scripture.HideRandomWord();
            Console.Clear();
            Console.WriteLine(scripture);
        }

        Console.WriteLine("All words are hidden. End of the program.");
    }
}
