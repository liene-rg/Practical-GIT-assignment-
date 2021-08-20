using System;

class As21
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please, enter day number(from 1 to 7) in the week:");
        int day = Int32.Parse(Console.ReadLine());
        switch (day)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                Console.WriteLine("It is a working day.");
                break;
            case 6:
            case 7:
                Console.WriteLine("It is holiday!");
                break;
            default:
                Console.WriteLine("Please add correct verification in the code");
                break;

        }
    }
}