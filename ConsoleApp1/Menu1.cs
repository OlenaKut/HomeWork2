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
        Console.WriteLine("You have selected 1 from the main menu.");
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
                    if (age <= 20)
                    {
                        Console.WriteLine($"Youth price: {youthPrice * ticketCount}kr.");
                    }
                    else if (age >= 64)
                    {
                        Console.WriteLine($"Pensioner price: {pensPrice * ticketCount}kr");
                    }
                    else
                    {
                        Console.WriteLine($"Adult price: {adultPrice * ticketCount}kr.");
                    }
                    Console.WriteLine("Press * to go back to the main menu.");
                    Console.WriteLine("Press 0 to exit.");
                }
            }

        }




    }
    public static void BuyOneTicket()
    {
        Console.WriteLine("You have selected to buy one ticket.");
        Console.WriteLine("Press * to go back to the main menu.");
        Console.WriteLine("How old are you?");
        string userAgeOne = Console.ReadLine() ?? string.Empty;
        int age = 0;
        if (int.TryParse(userAgeOne, out age))
        {
            if (age <= 20)
            {
                Console.WriteLine($"Youth price: {youthPrice}");
            }
            else if (age >= 64)
            {
                Console.WriteLine($"Pensioner price: {pensPrice}kr");
            }
            else
            {
                Console.WriteLine($"Adult price: {adultPrice}kr.");
            }
            Console.WriteLine("Press * to go back to the main menu.");
            Console.WriteLine("Press 0 to exit.");
        }
    }



}