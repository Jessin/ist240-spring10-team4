using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_dll.Entities
{
    class Missile : DefenceEquipment
    {
        DefenceEquipment.MissileCode MissileStatus;

        public DefenceEquipment.MissileCode MissileStatus1
        {
            get { return MissileStatus; }
            set { MissileStatus = value; }
        }
        int InventoryTotal;

        public int InventoryTotal1
        {
            get { return InventoryTotal; }
            set { InventoryTotal = value; }
        }



    }
}
