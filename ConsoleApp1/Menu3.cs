using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                inMenu = false;
            }

            Menu1.ReturnOrExit();

        }
    }
}