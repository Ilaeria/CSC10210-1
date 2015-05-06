using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part2
{
    //Create a parent "room" type for other types to inherit from.
    public class Room
    {
        private string roomIdentifier;
        private double roomSize;

        //Constructor
        protected Room(string identifier, double size)
        {
            roomIdentifier = identifier;
            roomSize = size;
        }

        //Setters and getters
        protected string identifier //Immutable
        {
            get
            {
                return roomIdentifier;
            }
            
        }

        public double size
        {
            get
            {
                return roomSize;
            }
            set
            {
                roomSize = value;
            }
        }

        //Print room details
        protected string PrintRoom(string identifier, double size)
        {
            string room = ("Room: " + identifier + ", Room Size: " + size);
            return room;
        }
    }
}
