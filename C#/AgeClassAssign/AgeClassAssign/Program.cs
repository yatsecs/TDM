using System;

public class Loans
{
    public static void Main(string[] args)
    {
        int age;
        Console.WriteLine("What is your age?");
        age = Convert.ToInt32(Console.ReadLine());
        if (age < 5)
        {
            Console.WriteLine("You're too young for school");
        }
        if (age == 5)
        {
            Console.WriteLine("You're in Reception");
        }
        if (age == 6)
        {
            Console.WriteLine("You're in Year 1");
        }
        if (age == 7)
        {
            Console.WriteLine("You're in Year 2");
        }
        if (age == 8)
        {
            Console.WriteLine("You're in Year 3");
        }
        if (age == 9)
        {
            Console.WriteLine("You're in Year 4");
        }
        if (age > 9)
        {
            Console.WriteLine("You're To old for this school");
        }
    }
}