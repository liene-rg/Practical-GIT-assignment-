using System;

class Assignment1
{
    static void Main(string[] args)
    {
        int variable1 = 4, variable2 = 2;
        //variable1 > variable2 ? variable1 : variable2; -- this returns the value
        int maxVal = variable1 > variable2 ? variable1 : variable2;
        Console.WriteLine(maxVal);
        Console.WriteLine(variable1 == variable2 ? "The variables are ok" : "The variables are not equal");
        Console.WriteLine(variable1 % 2 == 1 ? "Value " + variable2 + "is odd " : variable2 + " is equal");
        Console.WriteLine(variable2 % 2 == 1 ? "Value " + variable2 + "is odd " : variable1 + " is equal");

        if (variable1 < 0)
            Console.WriteLine("Value " + variable1 + "is negative");

        if (variable2 < 0)
            Console.WriteLine("Value " + variable2 + "is negative");

        if (variable1 < 100)
            Console.WriteLine("Value " + variable1 + "is less than 100");

        if (variable2 < 100)
            Console.WriteLine("Value " + variable2 + "is less than 100");
    }
}

