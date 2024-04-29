using System;
class Q6
{
    static void Main()
    {
        Console.WriteLine("Enter a five-digit number:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (IsFiveDigitNumber(number))
        {
            int newNumber = AddOneToEachDigit(number);
            Console.WriteLine($"New number after adding 1 to each digit: {newNumber}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a five-digit number.");
        }
    }
    static bool IsFiveDigitNumber(int number)
    {
        return number >= 10000 && number <= 99999;
    }
    static int AddOneToEachDigit(int number)
    {
        int result = 0;
        int multiplier = 1;
        while (number > 0)
        {
            int digit = (number % 10) + 1;
            result += digit * multiplier;
            multiplier *= 10;
            number /= 10;
        }
        return result;
    }
}