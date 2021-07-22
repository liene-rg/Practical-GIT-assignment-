using System;

class As23
{
    static void Main(string[] args)
    {

        double num1, num2;

        Console.WriteLine("Enter number 1:");
        if (!Double.TryParse(Console.ReadLine().Replace(".", ","), out num1))
        {
            Console.WriteLine("Input is incorrect!");
            return; // close the program
        }

        Console.WriteLine("Enter number 2:");
        if (!Double.TryParse(Console.ReadLine().Replace(".", ","), out num2))
        {
            Console.WriteLine("Input is incorrect!");
            return;
        }

        Console.WriteLine("Choose the operation ('+' addition, '-' subtract, '/' division, \n '*' multiplication, '%'- modulo, \n 'p': print out both elements; \n 'b': verify which element is bigger; \n 's': verify which element is smaller");
        char operation = Char.Parse(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '%':
                result = num1 % num2;
                break;
            case 'p':
                Console.WriteLine(num1 + " and " + num2);
                break;
            case 'b':
                Console.WriteLine(num1 > num2 ? num1 + " is bigger than " + num2 : num2 + " is bigger than " + num1);
                break;
            case 's':
                Console.WriteLine(num1 < num2 ? num1 + " is smaller than " + num2 : num2 + " is smaller than " + num1);
                break;
            default:
                Console.WriteLine("Operation provided is incorrect");
                return; // stop the program
        }

        Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + result);
    }
}