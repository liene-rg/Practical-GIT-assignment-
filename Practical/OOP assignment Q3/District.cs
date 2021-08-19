using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_2
{

    public class District
    {
        private string title, city;
        private int districtID;

        private ArrayList officersInDistrict = new ArrayList();


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

        public int getNumberOfOfficerInDistrict()
        {

            return this.officersInDistrict.Count;
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

    }

}
