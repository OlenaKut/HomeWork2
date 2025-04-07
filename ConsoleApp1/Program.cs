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
        Console.WriteLine("Press 1 to go to Bio.");
        Console.WriteLine("Press 0 to exit.");

        bool isAlive = true;

        do
        {
            string input = Console.ReadLine()?.ToUpper() ?? string.Empty;

            switch (input)
            {
                case "0":
                    isAlive = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                case "1":
                    Menu1.Bio();
                    break;
                default:
                    Console.WriteLine("Please select a valid choice!");
                    break;
            }

        } while (isAlive);

    }
}

