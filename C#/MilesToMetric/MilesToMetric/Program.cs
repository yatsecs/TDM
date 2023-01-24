using System;

public class HealthClub
{
    public static void Main(string[] args)
    {
        double kilometers;
        kilometers = 1.6;

        for (int miles = 1; miles < 10; miles++)
        {
            Console.WriteLine(miles * kilometers);
        }
    }
}