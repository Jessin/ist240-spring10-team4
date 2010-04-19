using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library_dll.Entities
{
    public class HUD : Equipment
    {
        private int speed, distance, fuel, wiperspeed, carRepair;
        private string direction, lIGHT;

        public string LIGHT
        {
            get { return lIGHT; }
            set { lIGHT = value; }
        }

 

        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public int CarRepair
        {
            get { return carRepair; }
            set { carRepair = value; }
        }

        public int Wiperspeed
        {
            get { return wiperspeed; }
            set { wiperspeed = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        
        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public int Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        
        

    }

}
