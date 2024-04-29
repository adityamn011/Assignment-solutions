using System;


    internal class ModerateQ1
    {
    static void Main()
    {
        PrintXPattern("Hello World!!");
    }
    static void PrintXPattern(string text)
    {
        int length = text.Length;
        int spacesBefore = 0;
        int spacesBetween = length - 2;
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < spacesBefore; j++)
            {
                Console.Write(" ");
            }
            Console.Write(text[i]);
            for (int j = 0; j < spacesBetween; j++)
            {
                Console.Write(" ");
            }
            if (i != length - 1)
            {
                Console.Write(text[length - i - 1]);
            }
            spacesBefore++;
            spacesBetween -= 2;
            Console.WriteLine();
        }
    }

}

