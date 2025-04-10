using System.Security.Cryptography.X509Certificates;
using MainMenu;

namespace MainMenu;
internal class Menu1
{
    private static int? youthPrice;
    private static int? pensPrice;
    private static int? adultPrice;

    static Menu1()
    {
        youthPrice = 80;
        pensPrice = 90;
        adultPrice = 120;
    }

    public static void Bio()

    {
        Console.WriteLine("You have selected to go to Bio.");
        Console.Write("How many tickets do you want to buy?");
        string userValue = Console.ReadLine() ?? string.Empty;

        if (userValue == "*")
        {
            return; // Återgår till huvudmenyn
        }

        if (userValue == "1")
        {
            BuyOneTicket();
            return;
        }
        else
        {
            int ticketCount = 0;
            if (int.TryParse(userValue, out ticketCount))
            {
                Console.WriteLine($"You have selected to buy {ticketCount} tickets.");
                Console.WriteLine("How old are you?");
                string userAgeMany = Console.ReadLine() ?? string.Empty;
                int age = 0;
                if (int.TryParse(userAgeMany, out age))
                {
                    if (age <= 20 && age > 5)
                    {
                        Console.WriteLine($"Your price for {ticketCount} persons is: {youthPrice * ticketCount}kr.");
                    }
                    else if (age >= 64 && age < 100)
                    {
                        Console.WriteLine($"Your price for {ticketCount} persons is: {pensPrice * ticketCount}kr.");
                    }
                    else if (age > 20 && age < 64)
                    {
                        Console.WriteLine($"Your price for {ticketCount} persons is: {pensPrice * ticketCount}kr");
                    }
                    else
                    {
                        Console.WriteLine("You can watch for free.");
                    }
                    ReturnOrExit();
                }
            }

        }

    }
    public static void BuyOneTicket()
    {
        Console.WriteLine("You have selected to buy one ticket.");
        Console.WriteLine("How old are you?");
        string userAgeOne = Console.ReadLine() ?? string.Empty;
        int age = 0;
        if (int.TryParse(userAgeOne, out age))
        {
            if (age <= 20 && age > 5)
            {
                Console.WriteLine($"Pensioner price: {youthPrice}kr");
            }
            else if (age >= 64 && age < 100)
            {
                Console.WriteLine($"Pensioner price: {pensPrice}kr");
            }
            else if (age > 20 && age < 64)
            {
                Console.WriteLine($"Adult price: {adultPrice}kr.");
            }
            else
            {
                Console.WriteLine("You can watch for free.");
            }
            ReturnOrExit();
        }
    }

    public static void ReturnOrExit()
    {
        Console.WriteLine("Press any key to go back to the main menu.");
        Console.WriteLine("Press 0 to exit.");
    }



}