using System;

    internal class ModerateQ12
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string reversedCaseString = ReverseCase(input);
            Console.WriteLine("Reversed case string: " + reversedCaseString);
        }
        static string ReverseCase(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLower(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
                else if (char.IsUpper(chars[i]))
                {
                    chars[i] = char.ToLower(chars[i]);
                }
            }
            return new string(chars);
        }

    }

