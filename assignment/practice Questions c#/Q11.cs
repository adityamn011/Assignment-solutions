using System;

    internal class Q11
    {
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        DisplayRightAngleTriangle(rows);
    }
    static void DisplayRightAngleTriangle(int rows)
    {
        int count = 0;
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                count++;
                Console.Write(count+" ");

            }
            Console.WriteLine();
        }
    }
}

