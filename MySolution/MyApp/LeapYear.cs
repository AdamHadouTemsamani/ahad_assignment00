using System;

namespace LeapYear;

public class LeapYear
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
                Console.WriteLine("Yay");
            }
            else
            {
                Console.WriteLine("Nay");
            }
        }



    }

    static bool IsLeapYear(int year)
    {
        //Should always return false
        if (year < 1582)
        {
            return false;
        }

        //Check if divisble
        if (year % 4 == 0)
        {
            return true;
        }
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            return false;
        }
        return false;
    }

    static bool isParsable(string input)
    {
        int a;
        try
        {
            int.TryParse(input, out a);
        }
        catch (FormatException)
        {
            Console.WriteLine($"Unable to parse '{input}'");
        }
        return true;
    }






}


