using System;

class Arrays1
{
    static void Main(string[] args)
    {
        // int[] arr = { 2, 54, 23, 91 };
        // Console.WriteLine(arr[0]);
        // Console.WriteLine(arr[1]);
        // Console.WriteLine(arr[2]);
        // Console.WriteLine(arr[3]);

        string[] arr = new string[5]; // must provide number of elements
        AddNewElement(0, ref arr);
        AddNewElement(1, ref arr);
        AddNewElement(2, ref arr);
        AddNewElement(3, ref arr);
        AddNewElement(4, ref arr);

        Console.WriteLine(arr[0] + arr[1] + arr[2] + arr[3] + arr[4]);

        // 2 dimensional arrays
        string[][] arr2Dim = new string[][]; // not correct syntax
        string[][] arr2Dim = new string[5][]; // correct syntax

    }

    public static void AddNewElement(int elementIndex, ref string[] arr)
    {
        Console.WriteLine("Provide the element number " + elementIndex);
        arr[elementIndex] = Console.ReadLine();
    }
}