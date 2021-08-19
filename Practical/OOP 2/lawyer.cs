using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace OOP_2
{

    public class Lawyer
    {
        private string name, surname;
        private int lawyerID, helpedInCrimesSolving;

        //private List<string> lawyersArray = new List<string>();
        private ArrayList lawyersList = new ArrayList();


        //no argument constructor 
        public Lawyer()
        {

        }

        // argument constructor
        public Lawyer(string name, string surname, int lawyerID, int helpedInCrimesSolving)
        {
            this.name = name;
            this.surname = surname;
            this.lawyerID = lawyerID;
            this.helpedInCrimesSolving = helpedInCrimesSolving;
        }

        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getSurname()
        {
            return this.surname;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;

        }

        public int getLawyerId()
        {
            return this.lawyerID;
        }

        public void setLawyerId(int lawyerID)
        {
            this.lawyerID = lawyerID;
        }


        public int getHelpedInCrimesSolving()
        {
            return this.helpedInCrimesSolving;
        }

        public void setHelpedInCrimesSolving(int helpedInCrimesSolving)
        {
            this.helpedInCrimesSolving = helpedInCrimesSolving;
        }


        public override string ToString()
        {
            return "Name : " + this.name + "\n" +
           "Surname : " + this.surname + "\n" +
            "Lawyer ID : " + this.lawyerID + "\n" +
           "Helped in crimes solving : " + this.helpedInCrimesSolving + "\n"; // Print lawyer objects
        }



        public void addLawyerToList(Lawyer lawyers)
        {
            this.lawyersList.Add(lawyers); // Add lawyers to lawyerslist

        }

        // public static int getByCasesSolvedLawyer(Lawyer lawyersList){

        // }

        //Find out the total number of the crimes in which solving the Lawyers were involved. 





        // public static int getCountByLawyerHelp(int helpedInCrimesSolving, Lawyer[] lawyers)
        // {
        //     int caseCount = 0;
        //     foreach (Lawyer lawyer in lawyers)
        //     {
        //         if (lawyer == null)///means that the cell of the array is empty
        //             continue;//go to the next iteration of the loop

        //         if (lawyer.getHelpedInCrimesSolving() == helpedInCrimesSolving)
        //             caseCount++;
        //     }
        //     return caseCount;
        // }

    }



}


