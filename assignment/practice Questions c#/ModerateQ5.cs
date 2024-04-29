using System;

    internal class ModerateQ5
    {
    static void Main()
    {
        int n = 5; 
        PrintDiamondPattern(n);
    }
    static void PrintDiamondPattern(int n)
    {
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
        for (int i = n - 2; i >= 0; i--)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
    

