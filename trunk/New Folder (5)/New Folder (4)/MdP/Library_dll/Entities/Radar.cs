using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_dll.Entities
{
    class Radar : DefenceEquipment
    {
        private int speed, distance, altitute, direction;

        public int Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public int Altitute
        {
            get { return altitute; }
            set { altitute = value; }
        }

        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

    }
}
