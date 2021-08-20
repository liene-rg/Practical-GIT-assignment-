using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)


        {
            Officer officer1 = new Officer();
            officer1.setCrimesSolved(10);
            officer1.setName("Jack");
            officer1.setSurname("Tall");
            officer1.setOfficerId(12345);
            Console.WriteLine(officer1 + "\n");

            Officer officer2 = new Officer();
            officer2.setCrimesSolved(21);
            officer2.setName("Tom");
            officer2.setSurname("Short");
            officer2.setOfficerId(12569);
            Console.WriteLine(officer2 + "\n");

            Officer officer3 = new Officer();
            officer3.setCrimesSolved(15);
            officer3.setName("John");
            officer3.setSurname("Medium");
            officer3.setOfficerId(125897);
            Console.WriteLine(officer3 + "\n");

            Officer officer4 = new Officer();
            officer4.setCrimesSolved(50);
            officer4.setName("Dan");
            officer4.setSurname("Wik");
            officer4.setOfficerId(12565);
            Console.WriteLine(officer4 + "\n");

            Officer officer5 = new Officer();
            officer5.setCrimesSolved(45);
            officer5.setName("Barry");
            officer5.setSurname("Foley");
            officer5.setOfficerId(12533);
            Console.WriteLine(officer5 + "\n"); //the method ToString will be called

            Officer officer6 = new Officer("Daniel", "Gibson", 125789, 89);
            Console.WriteLine(officer6 + "\n");

            Officer officer7 = new Officer("Chuck", "West", 125521, 3);
            Console.WriteLine(officer7 + "\n");

            District district1 = new District();
            district1.setCity("New York");
            district1.setTitle("District 1");
            district1.setDistrictId(15);
            Console.WriteLine(district1 + "\n");

            District district2 = new District("District 2", "Washington", 85);
            Console.WriteLine(district2 + "\n");


            Lawyer lawyer1 = new Lawyer("Rob", "Johnson", 1256, 45);
            lawyer1.addLawyerToList(lawyer1);
            Console.WriteLine(lawyer1 + "\n");


            Lawyer lawyer2 = new Lawyer();
            lawyer2.setName("Daniel");
            lawyer2.setSurname("Wick");
            lawyer2.setLawyerId(1245);
            lawyer2.setHelpedInCrimesSolving(54);
            lawyer2.addLawyerToList(lawyer2);
            Console.WriteLine(lawyer2 + "\n");

            Lawyer lawyer3 = new Lawyer("Ron", "Swanson", 1244, 38);
            lawyer3.addLawyerToList(lawyer3);
            Console.WriteLine(lawyer3 + "\n");



            Officer[] District99 = new Officer[9]; // store the officer objects in the array 
            District99[0] = officer1;
            District99[1] = officer2;
            District99[2] = officer3;
            District99[3] = officer4;
            District99[4] = officer5;
            District99[5] = officer6;
            District99[6] = officer7;



            Console.WriteLine("There are " + Officer.getCountByLevel(1, District99) +
                " officers with level 1 in District");

            Console.WriteLine("There are " + Officer.getCountByLevelMore(1, District99) +
            " officers with level greater than 1 in District");

            Console.WriteLine(Officer.checkNameExist("John", District99) ? "There is the officer John in Disctrict"
             : "There is no John in district");

            Console.WriteLine("Creating a new officer...");
            Officer myNewOfficer = new Officer();

            Console.WriteLine("Enter the Name");
            myNewOfficer.setName(Console.ReadLine());

            Console.WriteLine("Enter the Surname");
            myNewOfficer.setSurname(Console.ReadLine());

            Console.WriteLine("Enter Officer Id");
            while (true)
            {

                int officerId = -1;
                if (Int32.TryParse(Console.ReadLine(), out officerId))
                {
                    myNewOfficer.setOfficerId(officerId);
                    break;
                }
                else
                    Console.WriteLine("Value entered is not correct, please, try again");
            }

            Console.WriteLine("Enter Crimes Solved number");
            while (true)
            {

                int crimesSolved = -1;
                if (Int32.TryParse(Console.ReadLine(), out crimesSolved))
                {
                    myNewOfficer.setCrimesSolved(crimesSolved);
                    break;
                }
                else
                    Console.WriteLine("Value entered is not correct, please, try again");
            }

            int[] arrCasesLawyersHelped = new int[3];
            arrCasesLawyersHelped[0] = lawyer1.getHelpedInCrimesSolving();
            arrCasesLawyersHelped[1] = lawyer2.getHelpedInCrimesSolving();
            arrCasesLawyersHelped[2] = lawyer3.getHelpedInCrimesSolving();


            int casesLawyersHelped = arrCasesLawyersHelped.Sum();
            Console.WriteLine("Number of Cases lawyers involved " + casesLawyersHelped);


            if (lawyer1.getHelpedInCrimesSolving() == arrCasesLawyersHelped.Max())
                Console.WriteLine("Lawyer " + lawyer1.getName() + " helped the most with " + lawyer1.getHelpedInCrimesSolving() + " cases solved");

            if (lawyer2.getHelpedInCrimesSolving() == arrCasesLawyersHelped.Max())
                Console.WriteLine("Lawyer " + lawyer2.getName() + " helped the most with " + lawyer2.getHelpedInCrimesSolving() + " cases solved");

            if (lawyer3.getHelpedInCrimesSolving() == arrCasesLawyersHelped.Max())
                Console.WriteLine("Lawyer " + lawyer3.getName() + " helped the most with " + lawyer3.getHelpedInCrimesSolving() + " cases solved");


            District99[8] = myNewOfficer; // Add the myNewOfficer obj to District99 array 
            Console.WriteLine(myNewOfficer);


            // add / remove officers from districts 

            district1.addOfficerToDistrict(officer1);
            district1.addOfficerToDistrict(officer2);
            district1.addOfficerToDistrict(officer3);
            district1.addOfficerToDistrict(officer4);
            district1.removeOfficerFromDistrict(officer4);
            district2.addOfficerToDistrict(officer4);
            district2.addOfficerToDistrict(officer5);
            district2.addOfficerToDistrict(officer6);
            district2.addOfficerToDistrict(officer7);

            Console.WriteLine("There are " + district1.getNumberOfOfficerInDistrict() + " officers in District 1");
            Console.WriteLine("There are " + district2.getNumberOfOfficerInDistrict() + " officers in District 2");

            Console.WriteLine("The average level in District1 is " + district1.calculateAvgLevelInDistrict());
            Console.WriteLine("The average level in District2 is " + district2.calculateAvgLevelInDistrict());


        }
    }
}