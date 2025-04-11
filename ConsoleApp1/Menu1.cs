using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMenu;

namespace MainMenu;
internal class Menu1
{
    private static int? youthPrice;
    private static int? pensPrice;
    private static int? adultPrice;
    private static int? freeEntry;

    static Menu1()
    {
        youthPrice = 80;
        pensPrice = 90;
        adultPrice = 120;
        freeEntry = 0;
    }
    //cd ConsoleApp1 dotnet run
    public static void Bio()
    {
        Console.WriteLine("You have selected to go to Bio.");
        Console.Write("How many tickets do you want to buy?");
        string userValue = Console.ReadLine() ?? string.Empty;

        if (int.TryParse(userValue, out int ticketCount) && ticketCount > 0)
        {
            int totalPrice = 0;
            for (int i = 1; i <= ticketCount; i++)
            {
                Console.WriteLine($"For ticket {i}, how old is the person?");
                string userAgeInput = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(userAgeInput, out int age) && age > 0)
                {
                    int? ticketPrice = GetTicketPriceByAge(age);

                    if (ticketPrice.HasValue)
                    {
                        totalPrice += ticketPrice.Value;

                        if (ticketPrice.Value > 0)
                        {
                            Console.WriteLine($"The person with age {age} pays {ticketPrice}kr.");
                        }
                        else
                        {
                            Console.WriteLine($"The person with age {age} gets free entry.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid age entered. Please enter a valid age.");
                    i--;
                }
            }
            Console.WriteLine($"\nThe total price for {ticketCount} ticket(s) is: {totalPrice}kr.");
        }
        else
        {
            Console.WriteLine("Invalid ticket count. Please enter a valid number greater than 0.");
        }
        ReturnOrExit();
    }
    public static int? GetTicketPriceByAge(int age)
    {
        if (age <= 20 && age > 5)
            return youthPrice;
        else if (age >= 64 && age < 100)
            return pensPrice;
        else if (age > 20 && age < 64)
            return adultPrice;
        else
            return freeEntry;
    }


    public static void ReturnOrExit()
    {
        Console.WriteLine("Press any key to go back to the main menu.");
        Console.WriteLine("Press 0 to exit.");
    }



}