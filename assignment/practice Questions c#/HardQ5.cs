using System;

    internal class HardQ5
    {
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        DisplayPlaceValue(number);
    }
    static void DisplayPlaceValue(int number)
    {
        int divisor = 1;
        while (number > 0)
        {
            int digit = number % 10;
            int placeValue = digit * divisor;
            Console.WriteLine("Output: " + placeValue);
            divisor *= 10;
            number /= 10;
        }
    }

}

