using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library_dll.Entities
{
    public class MONSystem
    {
        private String errorCode, trafficCode;

        public String TrafficCode
        {
            get { return trafficCode; }
            set { trafficCode = value; }
        }

        public String ErrorCode
        {
            get { return errorCode; }
            set { errorCode = value; }
        }

    }
}
