using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OOP_assignment_Q4
{

    class Lawyer : Person
    {
        private int lawyerID, helpedInCrimesSolving;

        private ArrayList lawyersList = new ArrayList();

        //no argument constructor 
        public Lawyer()
        {

        }

        // argument constructor
        public Lawyer(string name, string surname, int lawyerID, int helpedInCrimesSolving) : base(name, surname)
        {

            this.lawyerID = lawyerID;
            this.helpedInCrimesSolving = helpedInCrimesSolving;
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

    }

}