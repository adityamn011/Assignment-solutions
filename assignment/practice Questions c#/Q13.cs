using System;

    internal class Q13
    {
        static void Main()
        {
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            DisplayNumPyramid(rows);
        }

        static void DisplayNumPyramid(int rows)
        {
        int count = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(count++);
                }
                Console.WriteLine();
            }
        }
    }

