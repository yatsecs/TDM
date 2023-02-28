using System;
using System.Runtime.CompilerServices;

namespace PizzaOrderingApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            double ThinCrust = 5.00;
            double DeepPan = 6.00;
            int crustType;

            double Ham = 3.00;
            double Mushrooms = 2.00;
            double MedVeg = 3.00;
            double ExtraCheese = 1.50;

            double distance;
            double delivery = 0.00;
            string name;
            string houseNum;
            string postCode;
            string fullOrder = "";
            double currentPrice = 0.00;
            double fullPrice = 0.00;
            int pizzaCount;
            int fulfilledPizza = 0;

            Console.WriteLine("Welcome to Average Pizza Joint! How far away is your location from our shop? (in miles)");
            distance = Convert.ToDouble(Console.ReadLine());

            if (distance > 8)
            {
                Console.WriteLine("We're sorry, but we don't deliver that far.");
                Environment.Exit(0);
            }
            if (distance <= 8 && distance > 5)
            {
                delivery = 5.00;
                Console.WriteLine("Your delivery price will be £" + delivery);
            }
            if (distance <= 5 && distance > 2)
            {
                delivery = 3.00;
                Console.WriteLine("Your delivery price will be £" + delivery);
            }
            if (distance <= 2)
            {
                delivery = 0;
                Console.WriteLine("Your delivery price will be FREE");
            }

            Console.WriteLine("What name should we put on this order?");
            name = Console.ReadLine();
            Console.WriteLine("What is your house number?");
            houseNum = Console.ReadLine();
            Console.WriteLine("And your postcode?");
            postCode = Console.ReadLine();

            Console.WriteLine("How many pizzas will you be ordering?");
            pizzaCount = Convert.ToInt32(Console.ReadLine());

            while (pizzaCount != fulfilledPizza)
            {
                fullOrder = (fullOrder + "Pizza " + (fulfilledPizza + 1));
                Console.WriteLine("Pick your crust type (1/2):\n1. Thin Crust\n2. Deep Pan");
                crustType = Convert.ToInt32(Console.ReadLine());
                if (crustType == 1)
                {
                    fullOrder = (fullOrder + "\nThin Crust");
                    currentPrice = (currentPrice + ThinCrust);
                }
                if (crustType == 2)
                {
                    fullOrder = (fullOrder + "\nDeep Pan");
                    currentPrice = (currentPrice + DeepPan);
                }

                Console.WriteLine("Would you like ham topping? (y/n)");
                if (Console.ReadLine() == "y")
                {
                    fullOrder = (fullOrder + ", ham");
                    currentPrice = (currentPrice + Ham);
                }

                Console.WriteLine("Would you like mushrooms topping? (y/n)");
                if (Console.ReadLine() == "y")
                {
                    fullOrder = (fullOrder + ", mushrooms");
                    currentPrice = (currentPrice + Mushrooms);
                }

                Console.WriteLine("Would you like Mediterranean vegetables topping? (y/n)");
                if (Console.ReadLine() == "y")
                {
                    fullOrder = (fullOrder + ", Mediterranean vegetables");
                    currentPrice = (currentPrice + MedVeg);
                }

                Console.WriteLine("Would you like Extra Cheese topping? (y/n)");
                if (Console.ReadLine() == "y")
                {
                    fullOrder = (fullOrder + ", extra cheese");
                    currentPrice = (currentPrice + ExtraCheese);
                }
                fullOrder = (fullOrder + " - £" + currentPrice + "\n\n");
                fullPrice = (fullPrice + currentPrice);
                currentPrice = 0.00;
                fulfilledPizza = (fulfilledPizza + 1);
            }
            fullPrice = (fullPrice + delivery);
            Console.WriteLine("INVOICE\n" + fullOrder + "\nFULL PRICE: £" + fullPrice);
            Console.ReadLine();
        }
           
    }
}