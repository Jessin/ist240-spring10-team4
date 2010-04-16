using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_dll.Entities
{
    class DefenceSystem : DefenceEquipment
    {
        public enum MissileCode
        {
            READY,
            FIRE,
            TRACKING,
            IMPACT,
            SELFDESTRUCT,
        }

        public enum DSMode
        {
            ONLINE,
            OFFLINE
        }

    }
}
