using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part2
{
    //Create a "bathroom" room type inheriting from generic parent "room".
    public class Bathroom : Room
    {
        private int bathroomBasins;
        private int bathroomConveniences;

        //Constructor
        public Bathroom(string identifier, double size, int basins, 
            int conveniences) : base(identifier, size)
        {
            bathroomBasins = basins;
            bathroomConveniences = conveniences;
        }

        //Setters and getters
        public int basins
        {
            get
            {
                return bathroomBasins;
            }
            set
            {
                bathroomBasins = value;
            }
        }

        public int conveniences
        {
            get
            {
                return bathroomConveniences;
            }
            set
            {
                bathroomConveniences = value;
            }
        }

        //Print room details
        public void PrintBathroom()
        {
            Console.WriteLine(PrintRoom(identifier, size) 
                + ", Basins: {0}, Conveniences: {1}", 
                bathroomBasins, bathroomConveniences);
        }
    }
}