using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library_dll.Entities
{
    public class HUDD : Equipment
    {
        private int speed, distance, fuel, wiperspeed;
        

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


        private string light;

        public string Light
        {
            get { return light; }
            set { light = value; }
        }

        
        
        private Direction directionCode;

        public Direction DirectionCode
        {
            get { return directionCode; }
            set { directionCode = value; }
        }
        private Weather weatherCode;
        private CarProblem errorCode;
        private Traffic trafficCode;

        public Traffic TrafficCode
        {
            get { return trafficCode; }
            set { trafficCode = value; }
        }

        public  CarProblem ErrorCode
        {
            get { return errorCode; }
            set { errorCode = value; }
        }



      
        public Weather WeatherCode
        {
            get { return weatherCode; }
            set { weatherCode = value; }
        }





        public enum Weather
        {
            Clear = 0,
            LightRain = 1,
            LightSnow = 2,
            HeavyRain = 3,
            HeavySnow = 4

        }

        public enum CarProblem
        {
            NoIssues = 0,
            OverHeat = 1,
            WasherFluid = 2,
            Oil = 3,
            FrontRightWheel = 4,
            FrontLeftWheel = 5,
            BackRightWheel = 6,
            BackLeftWheel = 7
        }

        public enum Traffic
        {
            Free = 1,
            LightTraffic = 2,
            MediumTraffic = 3,
            HeavyTraffic = 4
        }

        public enum Direction
        {
            North = 0,
            NorthEast = 1,
            East = 2,
            SouthEast = 3,
            South = 4,
            SouthWest = 5,
            West = 6,
            NorthWest = 7



        }

        


        
        

    }

}
