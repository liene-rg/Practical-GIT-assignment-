using System;

class As12
{
    static void Main(string[] args)
    {

        int day, month, year, format;


        Console.WriteLine("Please write the day:");
        if (!Int32.TryParse(Console.ReadLine(), out day))
        {
            Console.WriteLine("Input is incorrect");
            return;
        }

        if (day < 0 || day > 31)
        {
            Console.WriteLine("Incorrect day format");
            return;
        }

        else
            Console.WriteLine("Today is" + " " + day);

        Console.WriteLine("Please write the month:");
        if (!Int32.TryParse(Console.ReadLine(), out month))
        {
            Console.WriteLine("Input is incorrect");
            return;
        }
        if (month < 0 || month > 12)
        {
            Console.WriteLine("Incorrect month format");
            return;
        }
        else
            Console.WriteLine("Today is " + " " + month + " month");

        Console.WriteLine("Please write the year:");
        if (!Int32.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Input is incorrect");
            return;
        }
        if (year < 0)
        {
            Console.WriteLine("Incorrect year format");
            return;
        }
        else
            Console.WriteLine("The year is" + " " + year);

        Console.WriteLine("Please select the date formatting: 1 - YYYY/MM/DD, 2- YYYY.MM.DD: ");
        if (!Int32.TryParse(Console.ReadLine(), out format))
        {
            Console.WriteLine("Input is incorrect");
            return;
        }

        if (format == 1)
            Console.WriteLine("Your date is " + year + "/" + month + "/" + day);
        else if (format == 2)
            Console.WriteLine("Your date is " + year + "." + month + "." + day);
        else Console.WriteLine("Incorrect format type");


    }
}
