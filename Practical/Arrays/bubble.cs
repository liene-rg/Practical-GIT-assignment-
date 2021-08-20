using System;
using System.Linq;



class Bubble
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 100); // random num from 1 to 99
        }

        Console.WriteLine("Array to be sorted: ");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        BubbleSort(numbers);

        Console.ReadLine();
    }

    public static void BubbleSort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++) // length -1 so the array is not outside boundaries
        {
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                if (numbers[j] > numbers[j + 1]) // if j is bigger than next num (j+1)
                {
                    int temp = numbers[j]; // temporary variable 
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("The sorted array of numbers: ");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

    }
}





