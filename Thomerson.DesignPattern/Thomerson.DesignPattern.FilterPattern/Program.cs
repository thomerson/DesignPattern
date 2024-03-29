﻿using System;
using System.Collections.Generic;
using 过滤器模式;

namespace Thomerson.DesignPattern.FilterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();

            persons.Add(new Person("Robert", "Male", "Single"));
            persons.Add(new Person("John", "Male", "Married"));
            persons.Add(new Person("Laura", "Female", "Married"));
            persons.Add(new Person("Diana", "Female", "Single"));
            persons.Add(new Person("Mike", "Male", "Single"));
            persons.Add(new Person("Bobby", "Male", "Single"));

            Criteria male = new CriteriaMale();
            Criteria female = new CriteriaFemale();
            Criteria single = new CriteriaSingle();
            Criteria singleMale = new AndCriteria(single, male);
            Criteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males: ");
            printPersons(male.MeetCriteria(persons));

            Console.WriteLine("\nFemales: ");
            printPersons(female.MeetCriteria(persons));

            Console.WriteLine("\nSingle Males: ");
            printPersons(singleMale.MeetCriteria(persons));

            Console.WriteLine("\nSingle Or Females: ");
            printPersons(singleOrFemale.MeetCriteria(persons));

            Console.WriteLine("Hello World!");
        }

        public static void printPersons(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine("Person : [ Name : " + person.Name
                   + ", Gender : " + person.Gender
                   + ", Marital Status : " + person.MaritalStatus
                   + " ]");
            }
        }
    }
}
