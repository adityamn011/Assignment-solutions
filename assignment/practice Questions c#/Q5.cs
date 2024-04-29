using System;

    internal class Q5
    {
    
    static string StrWord(string str, int n)
    {
        string[] strings = str.Split('#');
        return strings[n - 1];


    }

    static void Main()
    {
        string str = "Deep#sea#fishing#is#a#dangerous#occupation#because#of#the#rough#sea";
        Console.WriteLine(StrWord(str, 6));
    }
}
    

