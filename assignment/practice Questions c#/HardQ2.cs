using System;

    internal class HardQ2
    {
    static void Main()

    {

        Console.WriteLine("Multiplicative Persistence of 39: " + Bugger(39));

        Console.WriteLine("Multiplicative Persistence of 999: " + Bugger(999));

        Console.WriteLine("Multiplicative Persistence of 4: " + Bugger(4));

    }

    static int Bugger(int number)

    {

        int persistence = 0;

        while (number >= 10)

        {

            int product = 1;

            while (number > 0)

            {

                product *= number % 10;

                number /= 10;

            }

            number = product;

            persistence++;

        }

        return persistence;

    }
}

