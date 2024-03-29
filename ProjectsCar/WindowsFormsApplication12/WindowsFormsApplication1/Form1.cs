﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using library_dll.Entities;
using library_dll;
using System.Xml;
using System.Xml.Serialization;
using System.IO;




namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            // start region

        }
        #region buttons

        private void DayButton_CheckedChanged(object sender, EventArgs e)
        {

        
        }

        private void NightButton_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void LightRainButton_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void LightSnowButton_CheckedChanged(object sender, EventArgs e)
        {

            

        }

        private void HeavyRainButton_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void HeavySnowButton_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void OHeatButton_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void WFluidButton_CheckedChanged(object sender, EventArgs e)
        {            

        }

        private void TPressureButton_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void OilButton_CheckedChanged(object sender, EventArgs e){
 

        }

       
        
        private void NoTraffButton_CheckedChanged(object sender, EventArgs e){


        }
        
        private void LightTraffButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void MediumTraffButton_CheckedChanged(object sender, EventArgs e)
        {


        }
        private void HeavyTraffButton_CheckedChanged(object sender, EventArgs e)
        {
 

        }


        #endregion 

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void TestButton_Click(object sender, EventArgs e)
        {
            

            library_dll.Entities.TestingSystem actualTest = new library_dll.Entities.TestingSystem();
            actualTest.WeatherCode = library_dll.Entities.TestingSystem.Weather.Clear;
            actualTest.ErrorCode = library_dll.Entities.TestingSystem.CarProblem.NoIssues;
            actualTest.TrafficCode= library_dll.Entities.TestingSystem.Traffic.Free;
            actualTest.DirectionCode = library_dll.Entities.TestingSystem.Direction.North;
            actualTest.Light = "OFF";


            library_dll.Entities.TestingSystem actualTest1 = new library_dll.Entities.TestingSystem();
            if (DayButton.Checked)
                actualTest.Light = "OFF";

            if (NightButton.Checked)
                actualTest.Light = "ON";
            if (ClearButton1.Checked)
                actualTest.WeatherCode = TestingSystem.Weather.Clear;
            if (LightRainButton.Checked)
                actualTest.WeatherCode = TestingSystem.Weather.LightRain;

            if (LightSnowButton.Checked)
            {
                actualTest.WeatherCode = TestingSystem.Weather.LightSnow;
                actualTest.Light = "ON";
            }
            if (HeavyRainButton.Checked)
            {
                actualTest.WeatherCode = TestingSystem.Weather.HeavyRain;
                actualTest.Light = "ON";
            }
            if (HeavySnowButton.Checked)
            {
                actualTest.WeatherCode = TestingSystem.Weather.HeavySnow;
                actualTest.Light = "ON";
            }
            

            if (OHeatButton.Checked)
                actualTest.ErrorCode = TestingSystem.CarProblem.OverHeat;
            if (WFluidButton.Checked)
                actualTest.ErrorCode = TestingSystem.CarProblem.WasherFluid;
            if (NoProblemButton.Checked)
                actualTest.ErrorCode = TestingSystem.CarProblem.NoIssues;
            if (OilButton.Checked)
                actualTest.ErrorCode = TestingSystem.CarProblem.Oil;

            if (TPressureButton.Checked)
            {
                int returnValue = library_dll.Entities.utility.RandomNumber(4, 7);
                //if (returnValue == 4)
                //    actualTest.ErrorCode = TestingSystem.CarProblem.FrontRightWheel;
                //else if (returnValue == 5)
                //    actualTest.ErrorCode = TestingSystem.CarProblem.FrontLeftWheel;
                //else if (returnValue == 6)
                //    actualTest.ErrorCode = TestingSystem.CarProblem.BackRightWheel;
                //else if (returnValue == 7)
                //    actualTest.ErrorCode = TestingSystem.CarProblem.BackLeftWheel;
                switch (returnValue)
                {
                    case 4:
                        actualTest.ErrorCode = TestingSystem.CarProblem.FrontRightWheel;
                        break;
                    case 5:
                        actualTest.ErrorCode = TestingSystem.CarProblem.FrontLeftWheel;
                        break;
                    case 6:
                        actualTest.ErrorCode = TestingSystem.CarProblem.BackRightWheel;
                        break;
                    case 7:
                        actualTest.ErrorCode = TestingSystem.CarProblem.BackLeftWheel;
                        break;
                }
            }

            if (NoTraffButton.Checked)
                actualTest.TrafficCode = TestingSystem.Traffic.Free;
            if (LightTraffButton.Checked)
                actualTest.TrafficCode = TestingSystem.Traffic.LightTraffic;
            if (MediumTraffButton.Checked)
                actualTest.TrafficCode = TestingSystem.Traffic.MediumTraffic;
            if (HeavyTraffButton.Checked)
                actualTest.TrafficCode = TestingSystem.Traffic.HeavyTraffic;
            

         

            


            
            int directionValue = library_dll.Entities.utility.RandomNumber(0, 7);
            //if (directionValue == 0)
            //    actualTest.DirectionCode = TestingSystem.Direction.North;
            //if (directionValue == 1)
            //    actualTest.DirectionCode = TestingSystem.Direction.NorthEast;
            //if (directionValue == 2)
            //    actualTest.DirectionCode = TestingSystem.Direction.East;
            //if (directionValue == 3)
            //    actualTest.DirectionCode = TestingSystem.Direction.SouthEast;
            //if (directionValue == 4)
            //    actualTest.DirectionCode = TestingSystem.Direction.South;
            //if (directionValue == 5)
            //    actualTest.DirectionCode = TestingSystem.Direction.SouthWest;
            //if (directionValue == 6)
            //    actualTest.DirectionCode = TestingSystem.Direction.West;
            //if (directionValue == 7)
            //    actualTest.DirectionCode = TestingSystem.Direction.NorthWest;
            switch (directionValue)
            {
                case 0:
                    actualTest.DirectionCode = TestingSystem.Direction.North;
                    break;
                case 1:
                    actualTest.DirectionCode = TestingSystem.Direction.NorthEast;
                    break;
                case 2:
                    actualTest.DirectionCode = TestingSystem.Direction.East;
                    break;
                case 3:
                    actualTest.DirectionCode = TestingSystem.Direction.SouthEast;
                    break;
                case 4:
                    actualTest.DirectionCode = TestingSystem.Direction.South;
                    break;
                case 5:
                    actualTest.DirectionCode = TestingSystem.Direction.SouthWest;
                    break;
                case 6:
                    actualTest.DirectionCode = TestingSystem.Direction.West;
                    break;
                case 7:
                    actualTest.DirectionCode = TestingSystem.Direction.NorthWest;
                    break;
                


            }


            #region normalxml2
            //library_dll.Entities.utility.Filename = "test3.xml";


            //XmlDocument doc = new XmlDocument();

            ////Using the object create the XML declaration object 
            //XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            ////Append the XML declaration to the doc object 
            //doc.AppendChild(docNode);
            ////<?xml version="1.0" encoding="UTF-8"?> 

            //XmlNode documentNode = doc.CreateElement("document");
            //doc.AppendChild(documentNode);


            //if (dayB == true)
            //{
            //    if (!heavyrainB == true)
            //    {
            //        carlight = "OFF";
            //        XmlNode lightNode = doc.CreateElement("Light");
            //        lightNode.AppendChild(doc.CreateTextNode(carlight));
            //        documentNode.AppendChild(lightNode);
            //    }
            //}
            
            //if (nightB == true)
            //{
            //    carlight = "ON";
            //    XmlNode lightNode = doc.CreateElement("Night");
            //    lightNode.AppendChild(doc.CreateTextNode(carlight));
            //    documentNode.AppendChild(lightNode);
            //}
             
            //if (lightrainB == true)
            //{
            //    XmlNode lightrainNode = doc.CreateElement("lightrain");
            //    lightrainNode.AppendChild(doc.CreateTextNode("1"));
            //    documentNode.AppendChild(lightrainNode);
            //}
            //if (lightsnowB == true)
            //{
            //    XmlNode lightsnowNode = doc.CreateElement("lightsnow");
            //    lightsnowNode.AppendChild(doc.CreateTextNode("2"));
            //    documentNode.AppendChild(lightsnowNode);
            //}

            //if (heavyrainB == true)
            //{
            //    XmlNode heavyrainNode = doc.CreateElement("heavyrain");
            //    heavyrainNode.AppendChild(doc.CreateTextNode("3"));
            //    documentNode.AppendChild(heavyrainNode);
            //    carlight = "ON";
            //    XmlNode lightNode = doc.CreateElement("Light");
            //    lightNode.AppendChild(doc.CreateTextNode(carlight));
            //    documentNode.AppendChild(lightNode);
            //}
            //if (heavysnowB == true)
            //{
            //    XmlNode heavysnowNode = doc.CreateElement("heavysnow");
            //    heavysnowNode.AppendChild(doc.CreateTextNode("4"));
            //    documentNode.AppendChild(heavysnowNode);
            //    carlight = "ON";
            //    XmlNode lightNode = doc.CreateElement("Light");
            //    lightNode.AppendChild(doc.CreateTextNode(carlight));
            //    documentNode.AppendChild(lightNode);
            //}
            //if (overheatB == true)
            //{
            //    XmlNode errorcodeNode = doc.CreateElement("errorcode");
            //    errorcodeNode.AppendChild(doc.CreateTextNode("1"));
            //    documentNode.AppendChild(errorcodeNode);

            //}
            //if (washerfluidB == true)
            //{
            //    XmlNode errorcodeNode = doc.CreateElement("errorcode");
            //    errorcodeNode.AppendChild(doc.CreateTextNode("2"));
            //    documentNode.AppendChild(errorcodeNode);

            //}
            //if (tirepressureB == true)
            //{
            //    XmlNode errorcodeNode = doc.CreateElement("errorcode");
            //    errorcodeNode.AppendChild(doc.CreateTextNode("3"));
            //    documentNode.AppendChild(errorcodeNode);

            //}
            //if (oilB == true)
            //{
            //    XmlNode errorcodeNode = doc.CreateElement("errorcode");
            //    errorcodeNode.AppendChild(doc.CreateTextNode("4"));
            //    documentNode.AppendChild(errorcodeNode);

            //}
            //if (freeB == true)
            //{
            //    XmlNode trafficNode = doc.CreateElement("trafficNode");
            //    trafficNode.AppendChild(doc.CreateTextNode("1"));
            //    documentNode.AppendChild(trafficNode);

            //}
            //if (lightTB == true)
            //{
            //    XmlNode trafficNode = doc.CreateElement("trafficNode");
            //    trafficNode.AppendChild(doc.CreateTextNode("2"));
            //    documentNode.AppendChild(trafficNode);

            //}
            //if ( mediumB== true)
            //{
            //    XmlNode trafficNode = doc.CreateElement("trafficNode");
            //    trafficNode.AppendChild(doc.CreateTextNode("3"));
            //    documentNode.AppendChild(trafficNode);

            //}
            //if (heavyB == true)
            //{
            //    XmlNode trafficNode = doc.CreateElement("trafficNode");
            //    trafficNode.AppendChild(doc.CreateTextNode("4"));
            //    documentNode.AppendChild(trafficNode);

            //}
            //doc.Save("test4.xml");

            #endregion


            XmlSerializer serializer = new XmlSerializer(typeof(library_dll.Entities.TestingSystem));
            TextWriter texterWriter = new StreamWriter("../../../../CarTestingInfo.xml");
            serializer.Serialize(texterWriter, actualTest);
            texterWriter.Close();

        }

        private void EXITBUTTON_Click(object sender, EventArgs e)
        {
            // on exit it will write to a file that it has been deleted if it has
            utility.DeleteFile();
            Application.Exit();
        }

       

        private void NoTraffButton_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region  defaltxml

            #region normalxml

            //XmlDocument doc = new XmlDocument();

            // //Using the object create the XML declaration object 
            // XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            // //Append the XML declaration to the doc object 
            // doc.AppendChild(docNode);
            // //<?xml version="1.0" encoding="UTF-8"?> 

            // XmlNode documentNode = doc.CreateElement("document");
            // doc.AppendChild(documentNode);

            // XmlNode speedNode = doc.CreateElement("speed");
            // speedNode.AppendChild(doc.CreateTextNode("40"));

            // /*XmlAttribute speedAttribute = doc.CreateAttribute("Type");
            // speedAttribute.Value = "Speed";
            // speedNode.Attributes.Append(speedAttribute); */
            // documentNode.AppendChild(speedNode);

            // XmlNode directionNode = doc.CreateElement("direction");
            // directionNode.AppendChild(doc.CreateTextNode("North"));

            // /*XmlAttribute directionAttribute = doc.CreateAttribute("Type");
            // directionAttribute.Value = "direction";
            // directionNode.Attributes.Append(directionAttribute);*/
            // documentNode.AppendChild(directionNode);

            // XmlNode distanceNode = doc.CreateElement("distance");
            // distanceNode.AppendChild(doc.CreateTextNode("500"));

            ///* XmlAttribute distanceAttribute = doc.CreateAttribute("Type");
            // distanceAttribute.Value = "distance";
            // distanceNode.Attributes.Append(distanceAttribute);*/
            // documentNode.AppendChild(distanceNode);

            // XmlNode wiperspeedNode = doc.CreateElement("wiperspeed");
            // wiperspeedNode.AppendChild(doc.CreateTextNode("0"));

            // /*XmlAttribute wiperspeedAttribute = doc.CreateAttribute("Type");
            // wiperspeedAttribute.Value = "wiperspeed";
            // wiperspeedNode.Attributes.Append(wiperspeedAttribute);*/
            // documentNode.AppendChild(wiperspeedNode);

            // XmlNode lightNode = doc.CreateElement("light");
            // lightNode.AppendChild(doc.CreateTextNode("OFF"));

            ///* XmlAttribute lightAttribute = doc.CreateAttribute("light");
            // lightAttribute.Value = "light";
            // lightNode.Attributes.Append(lightAttribute);*/
            // documentNode.AppendChild(lightNode);

            // doc.Save("test4.xml"); 
            #endregion

            // writes a default XML file on forum load so that the other 2 systems have something to read from.
            library_dll.Entities.TestingSystem tester = new library_dll.Entities.TestingSystem();
            tester.Light = "OFF";
            tester.WeatherCode = library_dll.Entities.TestingSystem.Weather.Clear;
            tester.ErrorCode = library_dll.Entities.TestingSystem.CarProblem.NoIssues;
            tester.TrafficCode = library_dll.Entities.TestingSystem.Traffic.Free;
            

            tester.DirectionCode = library_dll.Entities.TestingSystem.Direction.North;
            XmlSerializer serializer = new XmlSerializer(typeof(library_dll.Entities.TestingSystem));
            // the dots(../) means go up 1 folder.
            TextWriter textWriter = new StreamWriter("../../../../CarTestingInfo.xml");
            serializer.Serialize(textWriter, tester);
            textWriter.Close();




            #endregion
        }

        private void EXITBUTTON_Click_1(object sender, EventArgs e)
        {
            utility.DeleteFile();
            Application.Exit();
        }

        private void ClearButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HeavyTraffButton_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void NoProblemButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        // doing random for each buttons
        private void RandButton_Click(object sender, EventArgs e)
        {
            // day or night random
            int LightRand = library_dll.Entities.utility.RandomNumber(0, 5);
            // did more than 2 numbers for higher chance of change
            switch (LightRand)
            {
                case 0:
                case 1:
                case 2:
                    DayButton.Checked = true;
                   
                    break;
                case 3:
                case 4:
                case 5:
                    
                    NightButton.Checked = true;
                    
                    break;   

            }

            // weather random
            int ExterRand = library_dll.Entities.utility.RandomNumber(0, 5);
            // had problem with jus 0 - 4 : problem was the last button would never be checked.
            switch (ExterRand)
            {

                case 0:
                    ClearButton1.Checked = true;
                    break;
                case 1:
                    LightRainButton.Checked = true;
                    break;
                case 2:
                    LightSnowButton.Checked = true;
                    break;
                case 3:
                    HeavyRainButton.Checked = true;
                    break;
                case 4:
                    HeavySnowButton.Checked = true;
                    break;
            }
            // car problem random
            int InterRand = library_dll.Entities.utility.RandomNumber(0, 5);

            switch (InterRand)
            {

                case 0:
                    NoProblemButton.Checked = true;
                    break;
                case 1:
                    OHeatButton.Checked = true;
                    break;
                case 2:
                    WFluidButton.Checked = true;
                    break;
                case 3:
                    TPressureButton.Checked = true;
                    break;
                case 4:
                    OilButton.Checked = true;
                    break;
               
            }
            // traffic random 
            int TrafficRand = library_dll.Entities.utility.RandomNumber(0, 4);

            switch (TrafficRand)
            {

                case 0:
                    NoTraffButton.Checked = true;
                    break;

                case 1:
                    LightTraffButton.Checked = true;
                    break;
                case 2:
                    MediumTraffButton.Checked = true;
                    break;
                case 3:
                    HeavyTraffButton.Checked = true;
                    break;
            }


        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

     
        




        

        

        

        

        





       

      

       
    }
}
