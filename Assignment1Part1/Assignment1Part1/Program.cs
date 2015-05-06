//Author: Jennifer Doherty Student ID 22223407
//Title: CSC10210 S1 2015 Assignment 1 Part 1
//Date: 14/04/2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create and initialise array with constructor
            Contact[] myContacts = new Contact[3];

            for (int i = 0; i < myContacts.Length; i++)
            {
                myContacts[i] = new Contact("", "", "", 0, "");
            }

            //Display initial records
            Console.WriteLine("Initialised contacts array:");
            foreach (Contact contactRecord in myContacts)
            {
                contactRecord.GetRecord();
            }

            //Modify each field the same
            foreach (Contact contactRecord in myContacts)
            {
                contactRecord.last = "Jones";
                contactRecord.other = "Bob";
                contactRecord.company = "ABC Company";
                contactRecord.phone = 12345678;
                contactRecord.email = "bob@abcompany.com";
            }

            //Display modified records
            Console.WriteLine();
            Console.WriteLine("Press any key to display modified records");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Modified contacts array:");
            foreach (Contact contactRecord in myContacts)
            {
                contactRecord.GetRecord();
            }

            //Modify each field individually
                myContacts[0].last = "";
                myContacts[0].other = "Marcia";
                myContacts[0].company = "XYZ Company";
                myContacts[0].phone = 12345678;
                myContacts[0].email = "marcia@xyzcompany.com";

                myContacts[1].last = "Smith";
                myContacts[1].other = "Jane";
                myContacts[1].company = "XYZ Company";
                myContacts[1].phone = 0;
                myContacts[1].email = "jane@xyzcompany.com";

                myContacts[2].last = "Barnes";
                myContacts[2].other = "Joe";
                myContacts[2].company = "XYZ Company";
                myContacts[2].phone = 0;
                myContacts[2].email = "";
            
            //Display modified records
            Console.WriteLine();
            Console.WriteLine("Press any key to display unique records");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Modified contacts array:");
            foreach (Contact contactRecord in myContacts)
            {
                contactRecord.GetRecord();
            }
            
            //Display formatted records
            Console.WriteLine();
            Console.WriteLine("Press any key to display formatted records");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Formatted contacts array:");
            foreach (Contact contactRecord in myContacts)
            {
                contactRecord.PrintRecord();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
