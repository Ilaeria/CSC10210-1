using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part2
{
    //Create a "kitchen" room type inheriting from generic parent "room".
    class Kitchen : Room
    {
        private int kitchenSeating;
        private bool kitchenFridge;
        private bool kitchenMicrowave;

        //Constructor
        public Kitchen(string identifier, double size, int seating, 
            bool fridge, bool microwave) : base(identifier, size)
        {
            kitchenSeating = seating;
            kitchenFridge = fridge;
            kitchenMicrowave = microwave;
        }

        //Setters and getters
        public int seating
        {
            get
            {
                return kitchenSeating;
            }
            set
            {
                kitchenSeating = value;
            }
        }

        public bool fridge
        {
            get
            {
                return fridge;
            }
            set
            {
                kitchenFridge = value;
            }
        }

        public bool microwave
        {
            get
            {
                return microwave;
            }
            set
            {
                kitchenMicrowave = value;
            }
        }

        //Print room details
        public void PrintKitchen()
        {
            Console.WriteLine(PrintRoom(identifier, size) 
                + ", Seating: {0}, Fridge: {1}, Microwave: {2}", 
                kitchenSeating, kitchenFridge, kitchenMicrowave);
        }
    }
}