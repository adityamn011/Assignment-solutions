using System;

internal class ModerateQ9
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int n=int.Parse(Console.ReadLine());
        Console.WriteLine(num_of_digits(n));
           
    }
    static int num_of_digits(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        int count = 0;
        while (num != 0)
        {
            num /= 10;
            count++;
        }
        return count;

    }
}

