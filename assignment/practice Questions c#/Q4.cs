using System;

internal class Q4
{
    static int Strlen(string str)
    {
        int count = 0;
        foreach (char s in str)
        {
            count++;
        }
        return count;
    }
    static void Main(string[] args)

    {
        
        Console.WriteLine("Enter a String");
        string str = Console.ReadLine();
        
        Console.WriteLine($"Length of {str} is:{Strlen(str)}");
    }
}

