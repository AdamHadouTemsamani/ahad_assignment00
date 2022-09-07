using System;

namespace LeapYear;

public class LeapYearClass
{


    public static void Main(string[] args)
    {
        Console.WriteLine("Enter leap year:");
        string input = Console.ReadLine();
        int result;

        if (isParsable(input))
        {   
            result = Convert.ToInt32(input);

            if (IsLeapYear(result))
            {
                Console.WriteLine("yay");
            }
            else
            {
                Console.WriteLine("nay");
            }
        }

    }

    public static bool IsLeapYear(int year)
    {
        //Should always return false
        if (year < 1582)
        {
            return false;
        }

        //Check if divisble
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                    return false;
            }
        return true;
        }
        return false;
    }

    public static bool isParsable(string input)
    {
        try
        {
            Convert.ToInt32(input);
        }
        catch (FormatException)
        {
            Console.WriteLine($"Unable to parse '{input}'");
            return false;
        }
        
        return true;
    }

}


