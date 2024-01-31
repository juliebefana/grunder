using System;

class Program
{
    static void Main()
    {
        Exercise1();
        Exercise2();
        Exercise3();
        Exercise4();
    }

    static void Exercise1()
    {
        Console.Write("Enter some text: ");
        string userInput = Console.ReadLine();
        Console.WriteLine("You entered: " + userInput);
    }

    static void Exercise2()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1 + num2;
        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
    }

    static void Exercise3()
    {
        Console.Write("Enter the number of values to sum: ");
        int numberOfValues = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= numberOfValues; i++)
        {
            Console.Write($"Enter value {i}: ");
            int currentValue = Convert.ToInt32(Console.ReadLine());
            sum += currentValue;
        }

        Console.WriteLine($"The sum of the entered values is: {sum}");
    }

    static void Exercise4()
    {
        try
        {
            Console.Write("Enter input in the format <name: string> <age: int> <height: double>: ");
            string input = Console.ReadLine();

            string[] parts = input.Split(' ');

            if (parts.Length == 3)
            {
                string name = ValidateString(parts[0], "Name");
                int age = ValidatePositiveInt(parts[1], "Age");
                double height = ValidateDoubleInRange(parts[2], 0, 300, "Height");

                Console.WriteLine($"{name} är {age} år gammal och {height}cm lång.");
            }
            else
            {
                Console.WriteLine("Invalid input format. Please enter in the format <name: string> <age: int> <height: double>.");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static string ValidateString(string input, string fieldName)
    {
        if (!int.TryParse(input, out _))
        {
            return input;
        }
        else
        {
            throw new ArgumentException($"{fieldName} must be a valid string.");
        }
    }

    static int ValidatePositiveInt(string input, string fieldName)
    {
        if (int.TryParse(input, out int result) && result >= 0)
        {
            return result;
        }
        else
        {
            throw new ArgumentException($"{fieldName} must be a positive integer.");
        }
    }

    static double ValidateDoubleInRange(string input, double min, double max, string fieldName)
    {
        if (double.TryParse(input, out double result) && result >= min && result <= max)
        {
            return result;
        }
        else
        {
            throw new ArgumentException($"{fieldName} must be a double in the range {min}-{max}.");
        }
    }
}


