using System;
    internal class Q14
    {
    static void Main()
    {
        Console.WriteLine("The input starting number of range:");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("The input starting number of range:");
        int end = int.Parse(Console.ReadLine());


        bool isPrime = true;
        Console.WriteLine($"Prime Numbers from {start} and {end} is: ");
        for (int i = 2; i <= end; i++)
        {
            for (int j = 2; j <= end; j++)
            {

                if (i != j && i % j == 0)
                {
                    isPrime = false;
                    break;
                }

            }
            if (isPrime)
            {
                Console.Write(i+" ");
            }
            isPrime = true;
        }
        Console.ReadKey();
    }
}

