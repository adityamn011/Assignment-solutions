using System;

    internal class HardQ4
    {
    static void Main()
    {
        Console.Write("Input any number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int digitCount = CountDigits(number);
        Console.WriteLine("The number " + number + " contains the number of digits: " + digitCount);
    }
    static int CountDigits(int number)
    {
        if (number < 10)
        {
            return 1;
        }
        else
        {
            return 1 + CountDigits(number / 10);
        }
    }

}

