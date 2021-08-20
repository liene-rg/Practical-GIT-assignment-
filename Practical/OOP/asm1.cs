using System;

namespace Assigmn1
{

    public class Officer
    {

        private string name, surname, workingDistrict;
        private int officerID, crimesSolved;

        public Officer()
        {
            ///No-argument constructor
        }

        //Parameterized constructor
        public Officer(string name, string surname, string workingDistrict, int officerID, int crimesSolved)
        {
            this.crimesSolved = crimesSolved;
            this.name = name;
            this.surname = surname;
            this.workingDistrict = workingDistrict;
            this.officerID = officerID;
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

        public string getWorkingDistrict()
        {
            return this.workingDistrict;
        }

        public void setWorkingDistrict(string workingDistrict)
        {
            this.workingDistrict = workingDistrict;
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
          "District : " + this.workingDistrict + "\n" +
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

        public static int getCountByLevel(int level, Officer[] officers)
        {
            int count = 0;
            foreach (Officer officer in officers)
            {
                if (officer == null)///means that the cell of the array is empty
                    continue;//go to the next iteration of the loop

                if (officer.calculatedLevel() == level)
                    count++;
            }
            return count;
        }

        public static int getCountByLevelMore(int level, Officer[] officers)
        {
            int count = 0;
            foreach (Officer officer in officers)
            {
                if (officer == null)///means that the cell of the array is empty
                    continue;//go to the next iteration of the loop

                if (officer.calculatedLevel() > level)
                    count++;
            }
            return count;
        }

        public static bool checkNameExist(string name, Officer[] officers)
        {
            foreach (Officer officer in officers)
            {
                if (officer == null)///means that the cell of the array is empty
                    continue;//go to the next iteration of the loop

                if (officer.getName().Equals(name))
                    return true;
            }
            return false;
        }

    }

}