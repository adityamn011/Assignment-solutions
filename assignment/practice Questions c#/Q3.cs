using System;

    internal class Q3
    {
    static string RevStr(string s)
    {
        string str="";
        for (int i =0; i <= s.Length - 1; i++)
        {
            str += s[s.Length - 1-i];
            
        }
        return str;
    }
    static void Main()

    {
        Console.WriteLine("Enter a String");
        string str=Console.ReadLine();
        Console.WriteLine(RevStr(str));
    }
    }

