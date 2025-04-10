using System.Security.Cryptography.X509Certificates;
using MainMenu;

namespace MainMenu;

internal class Menu2
{
    public static void RepeatInputTenTimes()
    {
        Console.Write("Enter a text to repeat: ");
        string userInput = Console.ReadLine() ?? string.Empty;

        Console.Write("Output: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}. {userInput}");
            if (i < 10) Console.Write(", ");
        }
        Console.WriteLine();
        Menu1.ReturnOrExit();

    }
}