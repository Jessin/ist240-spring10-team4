﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library_dll.Entities
{
    class Equipment
    {
        protected string _model, _series;
        //protected CarSystem.CSMode mode;

        public string Series
        {
            get { return _series; }
            set { _series = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
    }
}
