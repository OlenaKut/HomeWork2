using System.Security.Cryptography.X509Certificates;
using MainMenu;

namespace MainMenu;

internal class Menu3
{
    public static void PlayWithStrings()
    {

        Console.Write("Enter at least three words: ");
        string userInput = Console.ReadLine() ?? string.Empty;
        userInput.Split(' ');
        string[] words = userInput.Split(' ');
        if (words.Length < 3)
        {
            Console.WriteLine("Please enter at least three words.");
            return;
        }
        else
        {
            Console.WriteLine("You entered: " + userInput);
            Console.WriteLine("The first word is: " + words[0]);
            Console.WriteLine("The second word is: " + words[1]);
            Console.WriteLine("The third word is: " + words[2]);
            Console.WriteLine("The last word is: " + words[words.Length - 1]);

            Console.WriteLine("Press * to go back to the main menu.");
            Console.WriteLine("Press 0 to exit.");
        }


    }
}