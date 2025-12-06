using System;
using System.ComponentModel.DataAnnotations;
public class Numbersign
{
    public static void Run()
    {
        Console.WriteLine("Enter a number:");
        string number = Console.ReadLine();
        if (int.TryParse(number, out int num)) { 
        if (num > 0)
        {
            Console.WriteLine($"{number} is a positive number");
        }
        else if (num < 0) {
            Console.WriteLine($"{number} is a negative number");
        }
        else if (num == 0)
        {
            Console.WriteLine($"Given Number is Zero");
        }
        }
        else
        {
            Console.WriteLine("Please provide a valid number.");
        }
    }
}


/*
 * DataType.TryParse(string input, out DataType variableName)
 * DataType → the type you want to convert to (e.g., int, double, bool)
 * input → the text you want to convert
 * out variableName → where the converted result will be stored if successful
 */