using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace MainMenu;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Main Menu!");


        bool isAlive = true;

        do
        {
            Console.WriteLine("Please press 0 to exit:");
            string input = Console.ReadLine().ToUpper() ?? string.Empty;

            switch (input)
            {
                case "0":
                    isAlive = false;
                    break;
                default:
                    Console.WriteLine("Please select a valid choice!");
                    break;
            }

        } while (isAlive);

    }
}

