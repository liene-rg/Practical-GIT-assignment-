using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OOP_assignment_Q4
{

    public class District
    {
        private string title, city;
        private int districtID;

        protected ArrayList officersInDistrict = new ArrayList();
        protected ArrayList personsInDistrict = new ArrayList();

        protected ArrayList districtsList = new ArrayList();


        public District()
        {
            ///No-argument constructor
        }


        public District(string title, string city, int districtID)
        {
            this.title = title;
            this.city = city;
            this.districtID = districtID;

        }

        public string getTitle()
        {
            return this.title;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public string getCity()
        {
            return this.city;
        }

        public void setCity(string city)
        {
            this.city = city;
        }

        public int getDistrictID()
        {
            return this.districtID;
        }

        public void setDistrictId(int districtID)
        {
            this.districtID = districtID;
        }

        public override string ToString()
        {
            return "District title : " + this.title + "\n" +
           "City : " + this.city + "\n" +
          "DistrictID : " + this.districtID + "\n";
        }


        public void addOfficerToDistrict(Officer officer)
        {
            this.officersInDistrict.Add(officer);

        }

        public void removeOfficerFromDistrict(Officer officer)
        {
            this.officersInDistrict.Remove(officer);

        }

        public void addPersonToDistrict(Person person)
        {
            this.personsInDistrict.Add(person);
        }

        public void removePersonFromDistrict(Person person)
        {
            this.personsInDistrict.Add(person);
        }
        public void addDistrict(District district)
        {
            this.districtsList.Add(district);
        }

        public void removeDistrict(District district)
        {
            this.districtsList.Add(district);
        }

        public int getNumberOfOfficerInDistrict()
        {

            return this.officersInDistrict.Count;
        }


        public int getNumOfPersonsInDistrict()
        {
            return this.personsInDistrict.Count;
        }


        public float calculateAvgLevelInDistrict()
        {
            int sum = 0;
            foreach (Officer officer in this.officersInDistrict)
            {
                if (officer == null)
                    break;
                sum += officer.calculatedLevel();
            }
            return (float)sum / (float)this.getNumberOfOfficerInDistrict();
        }

        int countOfficersInDistrict = 0;
        int sum;
        public float calculateOfficersInDistrict() // calculate officer count in districts
        {
            foreach (Person person in this.personsInDistrict)
            {
                if (!(person is Officer))
                    continue;

                Officer officer = (Officer)person;
                sum += officer.calculatedLevel();
                countOfficersInDistrict++;
            }
            return (float)sum / (float)countOfficersInDistrict;
        }


    }

}