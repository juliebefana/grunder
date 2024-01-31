using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter some text: ");

        string userInput = Console.ReadLine();

        Console.WriteLine("You entered: " + userInput);

        Console.Write("Enter the first number: ");

        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");

        double num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1 + num2;

        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
    }
}

