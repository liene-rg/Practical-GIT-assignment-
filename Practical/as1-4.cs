using System;

class As14
{
    static void Main(string[] args)
    {
        int day;

        Console.WriteLine("Please enter day");

        if (!Int32.TryParse(Console.ReadLine(), out day))
        {
            Console.WriteLine("Input is incorrect");
            return;
        }

        if (day >= 1 && day <= 31)
            Console.WriteLine("The day number is " + day + " it is January");
        else if (day >= 32 && day <= 59)
            Console.WriteLine("The day number is " + day + " it is February");
        else if (day >= 60 && day <= 90)
            Console.WriteLine("The day number is " + day + " it is March");
        else if (day >= 91 && day <= 120)
            Console.WriteLine("The day number is " + day + " it is April");
        else if (day >= 121 && day <= 151)
            Console.WriteLine("The day number is " + day + " it is May");
        else if (day >= 152 && day <= 181)
            Console.WriteLine("The day number is " + day + " it is June");
        else if (day >= 182 && day <= 212)
            Console.WriteLine("The day number is " + day + " it is July");
        else if (day >= 213 && day <= 243)
            Console.WriteLine("The day number is " + day + " it is August");
        else if (day >= 244 && day <= 273)
            Console.WriteLine("The day number is " + day + " it is September");
        else if (day >= 274 && day <= 304)
            Console.WriteLine("The day number is " + day + " it is October");
        else if (day >= 305 && day <= 334)
            Console.WriteLine("The day number is " + day + " it is November");
        else if (day >= 335 && day <= 365)
            Console.WriteLine("The day number is " + day + " it is December");
        else
            Console.WriteLine("Incorrect day format!");




    }
}