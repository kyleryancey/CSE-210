using System.Runtime.InteropServices;



class Menu
{

private string[] menuItems = {

    "Breathing Activity",
    "Reflecting Activity",
    "Listing Activty",
    "Quit"


};

public bool ChoiceAndExecute()
{
    Console.WriteLine("\nOptions");
    for (int i = 0; i < menuItems.Length; i++)
    {
        Console.WriteLine($"{i+1}. {menuItems[i]}");
    }

int choice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

switch (choice)
   {
    case 1:
        Breathing breathing = new Breathing();
        breathing.Run();
        break;
    case 2:
        Reflecting reflecting = new Reflecting();
        reflecting.Run();
        break;
    case 3:
        Listing listing = new Listing();
        listing.Run();
        break;
    case 4:
       Console.WriteLine("Thanks for playing!!");
       return false;
    default:
        Console.WriteLine("Sorry, please try again.");
        break;



   }
return true;
 }


}