using System;

class CoffeeShop
{
    static void Main()
    {
        string s1;
        const int CoffeePrice = 5;
        int totalAmountSpent = 0;
        do
        {
            Console.Write("Would you like to buy a coffee? (yes/no): ");
           s1 = Console.ReadLine().ToLower();

            if (s1 == "yes")
            {
                totalAmountSpent += CoffeePrice;
                Console.WriteLine("One coffee added. Your current total is: $" + totalAmountSpent.ToString("F2"));
            }
            else if (s1 != "no")
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }

        } while (s1 != "no");

        Console.WriteLine("Your total amount spent is: $" + totalAmountSpent.ToString("F2"));
    }
}

