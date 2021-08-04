using System;
using System.Linq;

namespace Arrays_2_Pract
{
    class Arr
    {
        static void Main(string[] args)
        {


            int[] array = { 10, 4, -4, 7, 0, 9, 1, 3, 7, -5 };

            // print out all negative numbers

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)

                    Console.Write(array[i] + " ");
            }

            Console.WriteLine(" ");


            // print out all odd numbers

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)

                    Console.Write(array[i] + " ");
            }


            // show how many odd elements in array 

            int oddNumCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    oddNumCount++;
            }

            Console.WriteLine("Number of odd elements = "
                     + oddNumCount);

            // check if the array contains multiple elements with the same value

            int firstElementOfArray = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (firstElementOfArray == array[i])
                    Console.WriteLine("There are elements with the same value in this array.");
            }


            for (int i = 0; i < array.Length; i++) // check if the array contains multiple elements with the same value
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        Console.WriteLine("The array contains elements with the same value of " + array[j]);
                }
            }

            //Print out each second element.


            for (int i = 0; i < array.Length; i += 2)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");

            //Compute average value of the array.
            Double sum = 0;
            Double averageValueOfArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = array.Sum();
                averageValueOfArray = sum / array.Length;
            }
            Console.WriteLine("The average value of array = " + averageValueOfArray);

            // Establish how many elements are smaller than average value.

            int elementsBelowAverage = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < averageValueOfArray)

                    elementsBelowAverage++;
            }
            Console.WriteLine("There are " + elementsBelowAverage + " elements that are below average.");
        }



    }
}

