using System;

    internal class ModerateQ14
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("LCM of " + num1 + " and " + num2 + " is: " + LCM(num1, num2));
            Console.WriteLine("GCD of " + num1 + " and " + num2 + " is: " + GCD(num1, num2));
        }
        static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
        static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }
    }

