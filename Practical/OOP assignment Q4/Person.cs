using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OOP_assignment_Q4
{

    public class Person
    {
        protected string name, surname;


        public Person()
        {
            ///No-argument constructor
        }

        //Parameterized constructor
        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;

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



    }
}