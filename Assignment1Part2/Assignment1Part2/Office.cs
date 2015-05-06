using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part2
{
    //Create an "office" room type inheriting from generic parent "room".
    public class Office : Room
    {
        private int officeDesks;
        private int officeFiling;

        //Constructor
        public Office(string identifier, double size, int desks, int filing) 
            : base(identifier, size)
        {
            officeDesks = desks;
            officeFiling = filing;
        }

        //Setters and getters
        public int desks
        {
            get
            {
                return officeDesks;
            }
            set
            {
                officeDesks = value;
            }
        }

        public int filing
        {
            get
            {
                return officeFiling;
            }
            set
            {
                officeFiling = value;
            }
        }

        //Print room details
        public void PrintOffice()
        {
            Console.WriteLine(PrintRoom(identifier, size) 
                + ", Desks: {0}, Filing: {1}", officeDesks, officeFiling);
        }
    }
}
