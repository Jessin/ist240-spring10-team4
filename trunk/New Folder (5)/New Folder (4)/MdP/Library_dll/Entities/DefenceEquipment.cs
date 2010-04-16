using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_dll.Entities
{
    class DefenceEquipment
    {
        protected string _model, _seriers;

       
        protected DefenceSystem.DSMode mode;


        public string Seriers
        {
            get { return _seriers; }
            set { _seriers = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

    }
}
