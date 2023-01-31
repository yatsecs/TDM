using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int age;
        Console.WriteLine("What you age");
        age = Convert.ToInt32(Console.ReadLine());

        switch (age)
        {
            case < 0:
                Console.WriteLine("Invalid");
                break;

            case < 16:
                Console.WriteLine("No drive");
                break;

            case < 120:
                Console.WriteLine("Yes driving");
                break;

            case > 120:
                Console.WriteLine("You are not that age");
                break;

            default:
                Console.WriteLine("Invalid");
                break;

        }
    }
}