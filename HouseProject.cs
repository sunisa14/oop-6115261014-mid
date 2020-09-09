using System;
using System.Collections.Generic;
using System.Text;

namespace oop_mid_6115261014
{
    class HouseProject
    {
    
        private string name;
        private House[] houses = new House[10];
        
        public HouseProject(string name,House[] houses)
        {
            this.name = name;
            this.houses = houses;

        }
        public string Name { get => name; set => name = value; }
        internal House [] Houses { get => houses; set => houses = value; }
        public override string ToString()
        {
            return this.Name + " " + this.Houses;
        }

    }
}