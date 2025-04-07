using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Numerics;

namespace MainMenu;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Main Menu!");
        Console.Clear();
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
    }
    private static bool MainMenu()
    {
        bool isAlive = true;

        Console.WriteLine("Press 1 to go to Bio.");
        Console.WriteLine("Press 2 to repeat input 10 times.");
        Console.WriteLine("Press 3 to play with the strings.");
        Console.WriteLine("Press 0 to exit.");

        do
        {
            string input = Console.ReadLine()?.ToUpper() ?? string.Empty;

            switch (input)
            {
                case "0":
                    isAlive = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return false;
                case "1":
                    Menu1.Bio();
                    break;
                case "2":
                    Menu2.RepeatInputTenTimes();
                    break;
                case "3":
                    Menu3.PlayWithStrings();
                    break;
                default:
                    return true;
            }
        } while (isAlive);
        return false; // Ensure a return value for all code paths


    }
}

