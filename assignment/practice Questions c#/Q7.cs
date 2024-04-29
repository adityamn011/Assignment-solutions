using System;

    internal class Q7
    {
    static void Main()
    {
        int count = 1;
        string str = "A tiger is a large-hearted gentleman with boundless courage";
        foreach (char s in str) { 
            if(s==' ')
            {
             count++;
            }
        }
        Console.WriteLine($"wordcount:{count}");
    }
}

