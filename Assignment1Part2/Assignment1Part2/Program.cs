//Author: Jennifer Doherty Student ID 22223407
//Title: CSC10210 S1 2015 Assignment 1 Part 2
//Date: 14/04/2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create and initialise rooms
            Office myOffice = new Office("Office", 0, 0, 0);
            Bathroom myBathroom = new Bathroom("Bathroom", 0, 0, 0);
            Kitchen myKitchen = new Kitchen("Kitchen", 0, 0, false, false);

            //Dump rooms
            Console.WriteLine("My initial rooms");
            myOffice.PrintOffice();
            myBathroom.PrintBathroom();
            myKitchen.PrintKitchen();
            Console.WriteLine();

            //Ask if user wants to modify rooms
            bool continueLoop = true; //Loop monitor

            do
            {
                Console.WriteLine("Would you like to modify a room? y/n");
                if (Console.ReadLine() == "n")
                {
                    continueLoop = false;
                }
                else
                {
                    try
                    {
                        Console.WriteLine
                            ("Would you like to modify the office? y/n");
                        if (Console.ReadLine() != "n")
                        {
                            Console.WriteLine("Enter office size: ");
                            myOffice.size = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter number of desks: ");
                            myOffice.desks = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Enter number of filing cabinets: ");
                            myOffice.filing = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Office updated!");
                        }

                        Console.WriteLine
                            ("Would you like to modify the bathroom? y/n");
                        if (Console.ReadLine() != "n")
                        {
                            Console.WriteLine("Enter bathroom size: ");
                            myBathroom.size = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter number of basins: ");
                            myBathroom.basins = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Enter number of conveniences: ");
                            myBathroom.conveniences = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Bathroom updated!");
                        }

                        Console.WriteLine
                            ("Would you like to modify the kitchen? y/n");
                        if (Console.ReadLine() != "n")
                        {
                            Console.WriteLine("Enter kitchen size: ");
                            myKitchen.size = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter number of seats: ");
                            myKitchen.seating = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Does the kitchen contain a fridge? y/n: ");
                            if (Console.ReadLine() == "y")
                            {
                                myKitchen.fridge = true;
                            }
                            else
                            {
                                myKitchen.fridge = false;
                            }
                            Console.WriteLine("Does the kitchen contain a microwave? y/n: ");
                            if (Console.ReadLine() == "y")
                            {
                                myKitchen.microwave = true;
                            }
                            else
                            {
                                myKitchen.microwave = false;
                            }
                            Console.WriteLine("Kitchen updated!");
                        }

                        //Dump rooms again
                        Console.WriteLine
                            ("Would you like to view the modified rooms? y/n");
                        if (Console.ReadLine() != "n")
                        {
                            Console.WriteLine("\n" + "My modified rooms");
                            myOffice.PrintOffice();
                            myBathroom.PrintBathroom();
                            myKitchen.PrintKitchen();
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("\n" + exception.Message);
                        Console.WriteLine
                            ("Your data is not in the correct format. Please try again. \n");
                    }
                }

                Console.ReadLine();
            }
            while (continueLoop);
        }
    }
}
