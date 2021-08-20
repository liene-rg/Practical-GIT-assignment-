using System;
using System.Linq;

namespace OOP_assignment_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Officer officer1 = new Officer();
            officer1.setName("Daniel");
            officer1.setSurname("Greg");
            officer1.setOfficerId(12345);
            officer1.setCrimesSolved(15);
            Console.WriteLine(officer1 + "\n");

            Officer officer2 = new Officer();
            officer2.setName("Tom");
            officer2.setSurname("Jon");
            officer2.setOfficerId(12344);
            officer2.setCrimesSolved(10);
            Console.WriteLine(officer2 + "\n");

            Officer officer3 = new Officer();
            officer3.setName("Linda");
            officer3.setName("Silva");
            officer3.setOfficerId(12555);
            officer3.setCrimesSolved(125);
            Console.WriteLine(officer3 + "\n");

            Officer officer4 = new Officer();
            officer4.setName("Carlos");
            officer4.setSurname("Ferguson");
            officer4.setOfficerId(12433);
            officer4.setCrimesSolved(54);
            Console.WriteLine(officer4 + "\n");


            Officer officer5 = new Officer("Jessica", "Bright", 12333, 60);
            Console.WriteLine(officer5 + "\n");

            Officer officer6 = new Officer("Daniel", "White", 12234, 88);
            Console.WriteLine(officer6 + "\n");

            Officer officer7 = new Officer("Greg", "Brown", 12478, 100);
            Console.WriteLine(officer7 + "\n");

            Lawyer lawyer1 = new Lawyer();
            lawyer1.setName("Gabriela");
            lawyer1.setSurname("Foley");
            lawyer1.setLawyerId(2256);
            lawyer1.setHelpedInCrimesSolving(80);
            Console.WriteLine(lawyer1 + "\n");

            Lawyer lawyer2 = new Lawyer();
            lawyer2.setName("Tom");
            lawyer2.setSurname("Jon");
            lawyer2.setLawyerId(5544);
            lawyer2.setHelpedInCrimesSolving(15);
            Console.WriteLine(lawyer2 + "\n");

            Lawyer lawyer3 = new Lawyer("Jessica", "Gibson", 7856, 45);
            Console.WriteLine(lawyer3 + "\n");



            District district1 = new District();
            district1.setCity("Los Angeles");
            district1.setDistrictId(10);
            district1.setTitle("District 1");
            district1.addPersonToDistrict(officer1);
            district1.addPersonToDistrict(officer1);
            district1.addPersonToDistrict(officer3);
            district1.addPersonToDistrict(lawyer1);
            district1.addPersonToDistrict(lawyer2);
            district1.addDistrict(district1);



            District district2 = new District();
            district2.setCity("New York");
            district2.setDistrictId(15);
            district2.setTitle("District 2");
            district2.addPersonToDistrict(officer4);
            district2.addPersonToDistrict(officer5);
            district2.addPersonToDistrict(officer6);
            district2.addPersonToDistrict(officer7);
            district2.addPersonToDistrict(lawyer3);
            district2.addDistrict(district2);



            Console.WriteLine("The average level in " + district1.getTitle() + " is " + district1.calculateOfficersInDistrict());
            Console.WriteLine("The average level in " + district2.getTitle() + " is " + district2.calculateOfficersInDistrict());

            Console.WriteLine("There are " + district1.getNumOfPersonsInDistrict() + " persons in " + district1.getTitle());
            Console.WriteLine("There are " + district2.getNumOfPersonsInDistrict() + " persons in " + district2.getTitle());

            if (district1.getNumOfPersonsInDistrict() > district2.getNumOfPersonsInDistrict())
                Console.WriteLine(district1.getTitle() + " has more persons");
            if (district1.getNumOfPersonsInDistrict() < district2.getNumOfPersonsInDistrict())
                Console.WriteLine(district2.getTitle() + " has more persons");
            else Console.WriteLine("Both districts have the same number of persons");




        }
    }
}
