using System;
using System.Text.RegularExpressions;


class stras4
{
    static void Main(string[] args)
    {
        string name = "John";

        if (Regex.IsMatch(name, "^[a-zA-Z]+$"))

            Console.WriteLine("good match");
        else
            Console.WriteLine("only letters allowed");

        string username = "s20surname";

        if (Regex.IsMatch(username, "^[a-z]\\d{2}[a-zA-Z]+$"))
            Console.WriteLine("good match");
        else
            Console.WriteLine("not a good username");

        string personCodeOfLatvian = "121200-11311";
        if (Regex.IsMatch(personCodeOfLatvian, "^[0-9]{6}-[0-9]{5}$"))
            //(Regex.IsMatch(personCodeOfLatvian, "^[0-9]{6}(\\s-\\s|-)[0-9]{5}$"))
            Console.WriteLine("correct person code");


        string sentence;
        Console.Write("Input the string: ");
        sentence = Console.ReadLine();

        Console.Write("\n");
        for (int i = sentence.Length - 1; i >= 0; i--)
        {
            Console.Write(sentence[i]);
        }

        Console.Write("\n");
        string[] wordsInString = sentence.Split(" ");

    }
}