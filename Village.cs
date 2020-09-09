using System;
using System.Collections.Generic;
using System.Text;

namespace oop_mid_6115261014
{
    class Village
    {

        private string name;
        private int val;

        public Village(string name, int val)
        {
            this.name = name;
            this.val = val;

        }
        public string Name { get => name; set => name = value; }
        public int  Val { get => val; set => val = value; }
        public override string ToString()
        {
            return this.Name + " " + this.Val;
        }
    }
}

 