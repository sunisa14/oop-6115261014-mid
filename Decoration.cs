using System;
using System.Collections.Generic;
using System.Text;
namespace oop_mid_6115261014
{
    class Decoration
    {
        private string name;
        private int cost;
        public Decoration()
        {
        }
        public Decoration(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
        public string Name { get => name; set => name = value; }
        public int Cost { get => cost; set => cost = value; }
        public override string ToString()
        {
            return this.Name + " " + this.Cost;
        }
    }
}