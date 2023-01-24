using System;
public class Taxes
{
    public static void Main(string[] args)
    {
        int yourWage;
        int tax;
        Console.WriteLine("What is your current wage?");
        yourWage=Convert.ToInt32(Console.ReadLine());
        if (yourWage <= 12000)
        {
            Console.WriteLine("You are not paying taxes.");
        }

        if (yourWage <= 45000)
        {
            yourWage = yourWage - 12000;
            tax = yourWage / 5;
            Console.WriteLine("You pay " + tax + " in tax");
        }

        if (yourWage > 45000)
        {
            yourWage = yourWage - 45000;
            tax = ((yourWage / 5) * 2) + 6600;
            Console.WriteLine("You pay " + tax + " in tax");
        }
    }
}