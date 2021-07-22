using System;

public class Calculatorswitch
{

    static void Main(string[] args)
    {
        double value1, value2;
        //bool inputCorrect = true;

        Console.WriteLine("Enter value 1:");
        if (!Double.TryParse(Console.ReadLine().Replace(".", ","), out value1))
        {
            Console.WriteLine("Input is incorrect!");
            return; // close the program
        }
        //double value1 = Double.Parse(Console.ReadLine().Replace(".", ","));

        Console.WriteLine("Enter value 2:");
        if (!Double.TryParse(Console.ReadLine().Replace(".", ","), out value2))
        {
            Console.WriteLine("Input is incorrect!");
            return;
        }
        //double value2 = Double.Parse(Console.ReadLine().Replace(".", ","));

        Console.WriteLine("Enter the operation (* - multiplication, / - division, + - addition, - - subtract, % - modulo");
        char operation = Char.Parse(Console.ReadLine());
        //char operation = Console.ReadLine()[0];

        double result;


        switch (operation)
        {
            case '*':
                result = value1 * value2;
                break;
            case '/':
                result = value1 / value2;
                break;
            case '-':
                result = value1 - value2;
                break;
            case '%':
                result = value1 % value2;
                break;
            case '+':
                result = value1 + value2;
                break;
            default:
                Console.WriteLine("Operation provided is incorrect");
                return; // stop the program
        }

        Console.WriteLine(value1 + " " + operation + " " + value2 + " = " + result);
    }

}