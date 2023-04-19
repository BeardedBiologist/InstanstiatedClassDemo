﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstanstiatedClassDemo;

namespace InstantiatedClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<PersonModel> people = new List<PersonModel>();

            //PersonModel person = new PersonModel();
            //person.firstName = "Tim";
            //people.Add(person);

            //person = new PersonModel();
            //person.firstName = "Sue";
            //people.Add(person);

            //foreach (PersonModel p in people)
            //{
            //    Console.WriteLine(p.firstName);
            //}

            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";

            do
            {
                Console.Write("What is your first name (or type exit to stop: ");
                firstName = Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    people.Add(person);
                }
            } while (firstName.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                Console.WriteLine(p.FirstName);
            }

            Console.ReadLine();

        }
    }
}