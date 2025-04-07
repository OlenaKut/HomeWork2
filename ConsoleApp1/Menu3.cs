using System.Security.Cryptography.X509Certificates;
using MainMenu;

namespace MainMenu;

internal class Menu3
{
    public static void PlayWithStrings()
    {
        bool inMenu = true;

        while (inMenu)
        {
            Console.Write("Enter at least three words: ");
            string userInput = Console.ReadLine() ?? string.Empty;
            string[] words = userInput.Split(' ');

            if (words.Length < 3)
            {
                Console.WriteLine("Please enter at least three words.");
                continue; // Starta om loopen för att låta användaren försöka igen
            }
            else
            {
                Console.WriteLine("You entered: " + userInput);
                Console.WriteLine("The first word is: " + words[0]);
                Console.WriteLine("The second word is: " + words[1]);
                Console.WriteLine("The third word is: " + words[2]);
                Console.WriteLine("The last word is: " + words[words.Length - 1]);
            }

            Console.WriteLine("\nPress * to go back to the main menu.");
            Console.WriteLine("Press 0 to exit.");

            string choice = Console.ReadLine() ?? string.Empty;

            if (choice == "*")
            {
                inMenu = false;
            }
            else if (choice == "0")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                Environment.Exit(0); // Avslutar programmet
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}