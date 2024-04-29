using System;

    internal class ModerateQ13
    {
        static void Main()
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();
            string codeWord = CreateCodeWord(input);
            Console.WriteLine("Code word: " + codeWord);
        }
        static string CreateCodeWord(string word)
        {
            string result = "";
            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    char newChar = (char)(c + 3);
                if ((char.IsUpper(c) && newChar > 'Z') || (char.IsLower(c) && newChar > 'z'))
                {
                    newChar = (char)(c - 23);
                }
                result += newChar;
            }

            
                
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }


