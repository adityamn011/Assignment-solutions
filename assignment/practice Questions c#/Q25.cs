using System;


internal class Q25
{
    static void Main()

    {
        Console.WriteLine("Enter a String");
        string str = Console.ReadLine();
        Console.WriteLine(FindMiddChar(str));
    }
    static string FindMiddChar(string str) { 
        int len = str.Length;
        int res = len / 2;
        if (len%2 == 0 ) {
            return str[res - 1].ToString() + str[res].ToString();
        }
        else
        {
            return str[res].ToString();
        }
    }
    
}

