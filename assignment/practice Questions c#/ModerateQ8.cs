using System;

    internal class ModerateQ8
    {
    static void Main()
    {
        string name = "What do you know about me? Out of everything I found nothing for you";
        string substringToFind = "ou";
        List<string> substrings = GetAllSubstrings(name);
        int count = CountOccurrences(substrings, substringToFind);
        Console.WriteLine("The substring \"" + substringToFind + "\" occurs " + count + " times in the sentence.");
    }
    static List<string> GetAllSubstrings(string str)
    {
        List<string> substrings = new List<string>();
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 1; j <= str.Length - i; j++)
            {
                substrings.Add(str.Substring(i, j));
            }
        }
        return substrings;
    }
    static int CountOccurrences(List<string> substrings, string substringToFind)
    {
        int count = 0;
        foreach (string substring in substrings)
        {
            if (substring.Equals(substringToFind))
            {
                count++;
            }
        }
        return count;
    }
}

