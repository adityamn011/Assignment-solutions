using System;

    internal class ModerateQ10
    {
        static void Main()
        {
            Console.Write("Input the original string: ");
            string originalString = Console.ReadLine();
            Console.Write("Input the string to be searched for: ");
            string searchString = Console.ReadLine();
            Console.Write("Input the string to be inserted: ");
            string insertString = Console.ReadLine();
            string modifiedString = InsertAfterFirst(originalString, searchString, insertString);
            Console.WriteLine("The modified string is: \"" + modifiedString + "\"");
        }
        static string InsertAfterFirst(string originalString, string searchString, string insertString)
        {
            int index = originalString.IndexOf(searchString);
            if (index == -1)
            {
                return originalString; // If the search string is not found, return the original string
            }
            return originalString.Substring(0, index + searchString.Length) + insertString + originalString.Substring(index + searchString.Length);
        }
    }

