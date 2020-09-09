using System;
using System.Collections.Generic;
using System.Text;
namespace oop_mid_6115261014
{
    class House
    {
        private int bedRoom;
        private int bathRoom;
        private float area;
        private Decoration decor;
        private Village villages;
        public int BedRoom { get => bedRoom; set => bedRoom = value; }
        public int BathRoom { get => bathRoom; set => bathRoom = value; }
        public float Area { get => area; set => area = value; }
        public Decoration Decor { get => decor; set => decor = value; }
        public Village Villages { get => villages; set => villages = value; }
        public House()
        {
        }
        public House(int bedRoom, int bathRoom, float area, Decoration decor, Village villages)
        {
            this.bedRoom = bedRoom;
            this.bathRoom = bathRoom;
            this.area = area;
            this.decor = decor;
            this.villages = villages;
        }
        public float getHouseCost(float area, int bedRoom, int bathRoom, Decoration decor)
        {
            float houseCost = 0;
            return houseCost = (this.area * this.villages.Val) + (this.bedRoom * 100000) + (this.bathRoom * 100000) + this.decor.Cost;
        }
        public override string ToString()
        {
            return "Location " + this.Villages.Name + " " +
                "House style" + this.Decor.Name + " " +
                "Bedroom " + this.BedRoom + " " +
                "Bathroom " + this.BathRoom + " " +
                "Area " + this.Area + " " + " Square" + " " +
                "Decor " + this.Decor.Cost + " " +
                "Cost " + this.getHouseCost(this.area, this.bedRoom, this.bathRoom, this.decor) + " Million baht";
        }
    }
}