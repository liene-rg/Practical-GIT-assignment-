using System;

class Arrays12
{
    static void Main(string[] args)
    {
        int[] array = { 5, 3, 7, 6, 2, 8 };

        // for (int i = 0; i < array.Length; i++)
        // {
        //     Console.WriteLine(array[i]);
        // }


        // foreach (int i in array)
        // {
        //     Console.WriteLine(i);
        // }

        int var = 0;
        while (var < array.Length)
        {
            Console.Write(array[var++] + " ");
        }





    }
}