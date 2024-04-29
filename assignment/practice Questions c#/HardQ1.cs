using System;

    internal class HardQ1
    {
    static void Main()
    {
        Console.Write("Enter alphanumeric: ");
        string input = Console.ReadLine();
        string pattern = GeneratePattern(input);
        Console.WriteLine("Pattern: " + pattern);
    }
    static string GeneratePattern(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";
        char startChar = input[0];
        string pattern = startChar.ToString();
        for (int i = 1; i < input.Length; i++)
        {
            if (char.IsDigit(input[i - 1]) && char.IsDigit(input[i]))
            {
                pattern += input[i];
            }
            else if (!char.IsDigit(input[i - 1]) && !char.IsDigit(input[i]))
            {
                pattern += input[i];
            }
        }
        return pattern;
    }

}

