using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LLD.OOP
{
    public class CompositionExample
    {
        House House = new House();
    }
    public class House
    { 
        private Room room1;
        private Room room2;
        public House()
        {
            room1 = new Room("Bedroom");
            room2 = new Room("Hall");
        }
    }


    /*When house object dies, so does the Room object, strong dependency.*/
    public class Room
    {
        private string name;
        public Room(string name)
        {
            this.name = name;
        }
    }
}
