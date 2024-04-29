using System;

    internal class HardQ3
    {
    static void Main()
    {
        Console.Write("Input any number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("The digits in the number " + number + " are: ");
        DisplayDigits(number);
        Console.WriteLine();
    }
    static void DisplayDigits(int number)
    {
        if (number < 10)
        {
            Console.Write(number + " ");
        }
        else
        {
            DisplayDigits(number / 10);
            Console.Write(number % 10 + " ");
        }
    }
}

