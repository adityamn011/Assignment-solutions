using System;

    internal class HardQ6
    {
    static void Main()
    {
        Console.Write("Enter the hour (0-23): ");
        int hour = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the minute (0-59): ");
        int minute = Convert.ToInt32(Console.ReadLine());
        double angle = CalculateClockAngle(hour, minute);
        Console.WriteLine("The angle between hour hand and minute hand is " + angle + " degrees");
    }

    static double CalculateClockAngle(int hour, int minute)
    {
        
        hour = hour % 12;
        
        double hourAngle = (hour * 30) + (minute * 0.5);
        double minuteAngle = minute * 6;
        
        double angle = Math.Abs(hourAngle - minuteAngle);
        
        {
            angle = 360 - angle;
        }
        return angle;
    }

    }

