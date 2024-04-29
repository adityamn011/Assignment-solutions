using System;
using System.Linq;

class Q26
{
    static void Main()
    {
        string inputString = "TiGer Is A LaRgE-HeArTeD GentlEmAN witH BounDleSS CouRAgE";
        string outputString = ConvertCase(inputString);
        Console.WriteLine("Input character:   " + inputString);
        Console.WriteLine("Output character:  " + outputString);
    }
    static string ConvertCase(string input)
    {
        char[] result = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
           
            if (c >= 'A' && c <= 'Z')
            {
                result[i] = (char)(c + 32);
            }
            
            else if (c >= 'a' && c <= 'z')
            {
                result[i] = (char)(c - 32);
            }
            
            else
            {
                result[i] = c;
            }
        }
        
        return string.Join("", result);
    }
}