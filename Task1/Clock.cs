using System;

public class Clock
{
    public const int minuteDeg = 6;
    public const int hourDeg = 30;
    public const double hoursPerMinDeg = 0.5;


    public static void Main1(string[] args)
    {
        int hours, minutes;
        while (true)
        {
            Console.WriteLine("Please enter hours"); 
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter minutes"); 
            minutes = Convert.ToInt32(Console.ReadLine());
            if (hours >= 0 && hours < 12 && minutes < 60 && minutes >= 0)
            {
                break;
            }
            Console.WriteLine("Bad input!");
        }

        double deg = hours * hourDeg - minutes * (minuteDeg - hoursPerMinDeg);

        if (deg < 0) deg = deg * -1;
        if (deg > 180) deg = 360 - deg; 
        
        Console.WriteLine("Answer: "+deg);

    }
    
    
}