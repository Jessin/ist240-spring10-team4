using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library_dll.Entities
{
    public class Hud : Equipment
    {
        private int speed, distance, fuel, direction;

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

        public int Direction
        {
            get { return direction; }
            set { direction = value; }
        }
    }
}
