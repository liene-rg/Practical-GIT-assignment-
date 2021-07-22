using System;

class As22
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade ('A', 'B', 'C', 'D', 'E', 'F)");
        char grade = Char.Parse(Console.ReadLine());

        switch (grade)
        {
            case 'A':
            case 'a':
            case 'B':
            case 'b':
                Console.WriteLine("Perfect! You are so clever!");
                break;
            case 'C':
            case 'c':
                Console.WriteLine("Good! But You can do better!");
                break;
            case 'D':
            case 'd':
            case 'E':
            case 'e':
                Console.WriteLine("It is not good! You should study!");
                break;
            case 'F':
            case 'f':
                Console.WriteLine("Fail! You need to repeat the exam!");
                break;
            default:
                Console.WriteLine("Incorrect grade value, please enter grade A to F");
                break;


        }
    }
}