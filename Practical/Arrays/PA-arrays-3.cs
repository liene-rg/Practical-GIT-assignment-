using System;
using System.Linq;

class arr
{
    static void Main(string[] args)
    {


        int[] array = null;
        int gradesOfArray = 0;


        while (gradesOfArray < 10)
        {
            Console.WriteLine("Enter the grade from 1 to 10.");
            int gradeInput;
            if (!Int32.TryParse(Console.ReadLine(), out gradeInput) || gradeInput <= 0 || gradeInput > 10)
                return;
            else
            {
                if (array != null)
                {
                    int[] copyArray = array;
                    array = new int[++gradesOfArray];
                    copyArray.CopyTo(array, 0);
                }
                else
                {
                    array = new int[++gradesOfArray];
                }
                array[gradesOfArray - 1] = gradeInput;
            }
        }


        int studentsThatFailed = 0;
        int studentsWithA = 0;



        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
            if (array[i] < 4)
                studentsThatFailed++;
            else if (array[i] == 10)
                studentsWithA++;


        }

        Console.WriteLine("\n" + studentsThatFailed + " students had grades of less than 4 and therefore have failed.");
        Console.WriteLine(studentsWithA + " students got the highest mark of A.");


        for (int j = 0; j < array.Length; j++)

            array[j] = array[j] - 1;

        for (int i = 0; i < array.Length; i++)

            array[array[i] % array.Length] = array[array[i] % array.Length] + array.Length;

        for (int i = 0; i < array.Length; i++)

            Console.WriteLine(array[i] / array.Length + " students with the grade " + (i + 1));


    }


}







