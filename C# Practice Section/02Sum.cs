using System;
public class Sum
{
    public static void Run()
    {
        Console.WriteLine("Enter First Number: ");
        int a=Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("Enter Second Number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sum is: {0}",a + b);
        Console.WriteLine($"Sum is: {a+b}"); //Use string interpolation
        Console.WriteLine("Sum is: " + (a + b));
    }
}