//Author: Jennifer Doherty Student ID 22223407
//Title: CSC10210 S1 2015 Assignment 1 Part 3
//Date: 14/04/2015
//Modified version of Part 1 to include exception handling.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part3
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
            Console.WriteLine("Default contact records:");
            foreach (Contact contactRecord in myContacts)
            {
                contactRecord.GetRecord();
            }

            Console.WriteLine();

            //Modify each field based on user input
            int recordIndex = 0; //index of which record user wants to change
            bool continueLoop = true; //Loop monitor

            do
            {
                Console.WriteLine
                    ("\n" + "Would you like to modify a record? y/n");
                if (Console.ReadLine() == "n")
                {
                    continueLoop = false;
                }
                else
                {
                    Console.WriteLine
                        ("Please enter which record you want to change: ");
                    try
                    {
                        recordIndex = Convert.ToInt16(Console.ReadLine());
                        if ((recordIndex >= 0) && (recordIndex <= myContacts.Length))
                        {
                            Console.WriteLine("Enter last name: ");
                            myContacts[recordIndex].last = Console.ReadLine();

                            //Throw exception if last name is blank
                            if (myContacts[recordIndex].last == "")
                            {
                                throw new ContactException
                                    (1, "Last name must not be blank");
                            }
                            Console.WriteLine("Enter other names: ");
                            myContacts[recordIndex].other = Console.ReadLine();
                            Console.WriteLine("Enter company: ");
                            myContacts[recordIndex].company = Console.ReadLine();
                            Console.WriteLine("Enter phone number: ");
                            myContacts[recordIndex].phone = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter email: ");
                            myContacts[recordIndex].email = Console.ReadLine();

                            //Throw exception if phone number and email are blank
                            if (myContacts[recordIndex].email == "")
                            {
                                if (myContacts[recordIndex].phone == 0)
                                {
                                    throw new ContactException
                                        (2, "Contact must have a phone number or an email");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine
                                ("You must enter a number between 0 and 2. Please try again. \n");
                        }

                        Console.WriteLine
                            ("\n" + "Record {0} updated. Would you like to modify another record? y/n", 
                            recordIndex);
                        if (Console.ReadLine() == "n")
                        {
                            continueLoop = false;
                        }
                    }
                    catch (FormatException formatException) //standard exception handling for non-integers
                    {
                        Console.WriteLine("\n" + formatException.Message);
                        Console.WriteLine
                            ("You must enter a whole number. Please try again. \n");
                    }
                    catch (ContactException contactException)
                    {
                        Console.WriteLine
                            ("Error code: " + contactException.code + "\n" + contactException.error);
                    }
                }
            }
            while (continueLoop);

            continueLoop = true; //Reset loop monitor
            do
            {
                //Display modified records
                Console.WriteLine
                    ("\n" + "Would you like to display modified records? y/n");
                if (Console.ReadLine() == "n")
                {
                    continueLoop = false;
                }
                else
                {
                    Console.WriteLine("Modified records:");
                    foreach (Contact contactRecord in myContacts)
                    {
                        contactRecord.GetRecord();
                    }
                    continueLoop = false;
                }
            }
            while (continueLoop);


            continueLoop = true; //Reset loop monitor
            do
            {
                //Display formatted records
                Console.WriteLine
                    ("\n" + "Would you like to display formatted records? y/n");
                if (Console.ReadLine() == "n")
                {
                    continueLoop = false;
                }
                else
                {
                    foreach (Contact contactRecord in myContacts)
                    {
                        contactRecord.PrintRecord();
                        Console.WriteLine();
                    }
                    continueLoop = false;
                }
            }
            while (continueLoop);

            Console.ReadLine();
        }
    }
}
