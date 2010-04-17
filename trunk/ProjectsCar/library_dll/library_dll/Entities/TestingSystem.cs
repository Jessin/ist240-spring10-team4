using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library_dll.Entities
{
   public class TestingSystem
    {
        private string light;
        private int weatherCode, traffiCode, errorCode, directionCode;

        public int DirectionCode
        {
            get { return directionCode; }
            set { directionCode = value; }
        }

        public string Light
        {
          get { return light; }
          set { light = value; }
        }

       

        public int WeatherCode
        {
          get { return weatherCode; }
          set { weatherCode = value; }
        }

        public int ErrorCode
        {
          get { return errorCode; }
          set { errorCode = value; }
        }

        public int TraffiCode
        {
          get { return traffiCode; }
          set { traffiCode = value; }
        }
           

    }
}
