using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_2
{

    public class Officer : Person
    {

        private int officerID, crimesSolved;

        public Officer()
        {
            ///No-argument constructor
        }

        //Parameterized constructor
        public Officer(string name, string surname, int officerID, int crimesSolved) : base(name, surname)
        {

            this.officerID = officerID;
            this.crimesSolved = crimesSolved;
        }

        public int getOfficerId()
        {
            return this.officerID;
        }

        public void setOfficerId(int officerID)
        {
            this.officerID = officerID;
        }

        public int getCrimesSolved()
        {
            return this.crimesSolved;
        }

        public void setCrimesSolved(int crimesSolved)
        {
            this.crimesSolved = crimesSolved;
        }

        public override string ToString()
        {
            return "Name : " + this.name + "\n" +
           "Surname : " + this.surname + "\n" +
            "Officer ID : " + this.officerID + "\n" +
           "Crimes Solved : " + this.crimesSolved + "\n" +
           "Level : " + this.calculatedLevel();
        }


        public int calculatedLevel()
        {
            if (this.crimesSolved < 20)
                return 1;
            if (this.crimesSolved < 40)
                return 2;
            else
                return 3;

        }
        public static int getCountByLevel(int level, Officer[] officers) // count how many officers have specific level
        {
            int count = 0;
            foreach (Officer officer in officers)
            {
                if (officer == null)
                    continue;

                if (officer.calculatedLevel() == level)
                    count++;
            }
            return count;
        }

        public static int getCountByLevelMore(int level, Officer[] officers) // how many officers have level greater than 1 
        {
            int count = 0;
            foreach (Officer officer in officers)
            {
                if (officer == null)
                    continue;
                if (officer.calculatedLevel() > level)
                    count++;
            }
            return count;
        }

        public static bool checkNameExist(string name, Officer[] officers) // check if officer with a specific name exists
        {
            foreach (Officer officer in officers)
            {
                if (officer == null)
                    continue;
                if (officer.getName().Equals(name))
                    return true;
            }
            return false;
        }

    }

}