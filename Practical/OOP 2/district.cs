using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_2
{

    public class District
    {
        private string title, city;
        private int districtID;
        //private Officer[] officersInTheDistrict;
        private ArrayList officersInDistrict = new ArrayList();
        //private int lastIndexOfficer = -1;

        public District()
        {
            ///No-argument constructor
        }
        // public District(int numberOfOfficer) // numberOfOfficer is the array size
        // {
        //     this.officersInDistrict = new Officer[numberOfOfficer];
        // }

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
            //     if (lastIndexOfficer == this.officersInTheDistrict.Length - 1) // if the array is full (lastindex == num of elements)
            //     {
            //         Console.WriteLine("No more officers can be added");
            //         return;
            //     }

            //     lastIndexOfficer++;
            //     this.officersInTheDistrict[lastIndexOfficer] = officer; // adding officer to the array 

        }

        public void removeOfficerFromDistrict(Officer officer)
        {
            this.officersInDistrict.Remove(officer);
            //     // int position = -1;
            //     // foreach (Officer officerInDistrict in officersInTheDistrict) // if provided officer equals in array
            //     // {
            //     //     position++; // start at -1 so this is position 0
            //     //     if (officerInDistrict == officer)
            //     //     {
            //     //         if (position != this.officersInTheDistrict.Length - 1) // if removing the element from the last position
            //     //             Array.Copy(officersInTheDistrict, position + 1,
            //     //              officersInTheDistrict, position, officersInTheDistrict.Length - position - 1);///shifting to right

            //     //         this.officersInTheDistrict[this.lastIndexOfficer] = null; // last position empty
            //     //         this.lastIndexOfficer--; // remove the last element
            //     //         return;
            //     //     }
            // }
            // Console.WriteLine("Officer does not exist in the district");
        }

        public int getNumberOfOfficerInDistrict()
        {
            // int count = 0;
            // foreach (Officer officer in this.officersInTheDistrict)
            // {
            //     // if (officer != null)
            //     //     count++;
            //     if (officer == null)//if we reached empty cell of the array, we should stop
            //         break;
            //     else
            //         count++;
            // }
            // return count;
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