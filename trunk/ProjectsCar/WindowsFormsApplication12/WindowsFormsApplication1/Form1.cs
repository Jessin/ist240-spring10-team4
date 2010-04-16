using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using library_dll;
using System.Xml;





namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool dayB;
        bool nightB;
        bool lightrainB;
        bool lightsnowB;
        bool heavyrainB;
        bool heavysnowB;
        bool overheatB;
        bool washerfluidB;
        bool tirepressureB;
        bool oilB;
        bool freeB;
        bool lightB;
        bool mediumB;
        bool heavyB;
        string carlight;





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        /*library_dll.Entities.HUD CARHUD = new library_dll.Entities.HUD();
        library_dll.Entities.MONSystem CARMON = new library_dll.Entities.MONSystem();*/

        

        private void StartButton_Click(object sender, EventArgs e)
        {

            #region  defaltxml

            
            XmlDocument doc = new XmlDocument();

            //Using the object create the XML declaration object 
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            //Append the XML declaration to the doc object 
            doc.AppendChild(docNode);
            //<?xml version="1.0" encoding="UTF-8"?> 

            XmlNode documentNode = doc.CreateElement("document");
            doc.AppendChild(documentNode);

            XmlNode speedNode = doc.CreateElement("speed");
            speedNode.AppendChild(doc.CreateTextNode("40"));

            /*XmlAttribute speedAttribute = doc.CreateAttribute("Type");
            speedAttribute.Value = "Speed";
            speedNode.Attributes.Append(speedAttribute); */
            documentNode.AppendChild(speedNode);
            
            XmlNode directionNode = doc.CreateElement("direction");
            directionNode.AppendChild(doc.CreateTextNode("North"));

            /*XmlAttribute directionAttribute = doc.CreateAttribute("Type");
            directionAttribute.Value = "direction";
            directionNode.Attributes.Append(directionAttribute);*/
            documentNode.AppendChild(directionNode);

            XmlNode distanceNode = doc.CreateElement("distance");
            distanceNode.AppendChild(doc.CreateTextNode("500"));

           /* XmlAttribute distanceAttribute = doc.CreateAttribute("Type");
            distanceAttribute.Value = "distance";
            distanceNode.Attributes.Append(distanceAttribute);*/
            documentNode.AppendChild(distanceNode);

            XmlNode wiperspeedNode = doc.CreateElement("wiperspeed");
            wiperspeedNode.AppendChild(doc.CreateTextNode("0"));

            /*XmlAttribute wiperspeedAttribute = doc.CreateAttribute("Type");
            wiperspeedAttribute.Value = "wiperspeed";
            wiperspeedNode.Attributes.Append(wiperspeedAttribute);*/
            documentNode.AppendChild(wiperspeedNode);

            XmlNode lightNode = doc.CreateElement("light");
            lightNode.AppendChild(doc.CreateTextNode("OFF"));

           /* XmlAttribute lightAttribute = doc.CreateAttribute("light");
            lightAttribute.Value = "light";
            lightNode.Attributes.Append(lightAttribute);*/
            documentNode.AppendChild(lightNode);

            doc.Save("test4.xml");
            #endregion

        }
        #region buttons

        private void DayButton_CheckedChanged(object sender, EventArgs e)
        {
            dayB = true;
            
        
        }

        private void NightButton_CheckedChanged(object sender, EventArgs e)
        {
            nightB = true;
            

        }

        private void LightRainButton_CheckedChanged(object sender, EventArgs e)
        {
            lightrainB = true;
            
            

        }

        private void LightSnowButton_CheckedChanged(object sender, EventArgs e)
        {
            lightsnowB = true;
            

        }

        private void HeavyRainButton_CheckedChanged(object sender, EventArgs e)
        {
            heavyrainB= true;
            
        }

        private void HeavySnowButton_CheckedChanged(object sender, EventArgs e)
        {
            heavysnowB = true;
            
        }

        private void OHeatButton_CheckedChanged(object sender, EventArgs e)
        {
            overheatB = true;
            
        }

        private void WFluidButton_CheckedChanged(object sender, EventArgs e)
        {
            washerfluidB = true;
            

        }

        private void TPressureButton_CheckedChanged(object sender, EventArgs e)
        {
            tirepressureB = true;
            
        }

        private void OilButton_CheckedChanged(object sender, EventArgs e)
        {
           oilB = true;

        }
        
        private void NoTraffButton_CheckedChanged(object sender, EventArgs e)
        {
            freeB = true;

        }
        
        private void LightTraffButton_CheckedChanged(object sender, EventArgs e)
        {
            lightB = true;
        }
        private void MediumTraffButton_CheckedChanged(object sender, EventArgs e)
        {
            mediumB = true;

        }
        private void HeavyTraffButton_CheckedChanged(object sender, EventArgs e)
        {
            heavyB = true;

        }


        #endregion 

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void TestButton_Click(object sender, EventArgs e)

        {
            library_dll.Entities.utility.Filename = "test3.xml";


            XmlDocument doc = new XmlDocument();

            //Using the object create the XML declaration object 
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            //Append the XML declaration to the doc object 
            doc.AppendChild(docNode);
            //<?xml version="1.0" encoding="UTF-8"?> 

            XmlNode documentNode = doc.CreateElement("document");
            doc.AppendChild(documentNode);


            if (dayB == true)
            {
                if (!heavyrainB == true)
                {
                    carlight = "OFF";
                    XmlNode lightNode = doc.CreateElement("Light");
                    lightNode.AppendChild(doc.CreateTextNode(carlight));
                    documentNode.AppendChild(lightNode);
                }
            }
            
            if (nightB == true)
            {
                carlight = "ON";
                XmlNode lightNode = doc.CreateElement("Night");
                lightNode.AppendChild(doc.CreateTextNode(carlight));
                documentNode.AppendChild(lightNode);
            }
             
            if (lightrainB == true)
            {
                XmlNode lightrainNode = doc.CreateElement("lightrain");
                lightrainNode.AppendChild(doc.CreateTextNode("1"));
                documentNode.AppendChild(lightrainNode);
            }
            if (lightsnowB == true)
            {
                XmlNode lightsnowNode = doc.CreateElement("lightsnow");
                lightsnowNode.AppendChild(doc.CreateTextNode("2"));
                documentNode.AppendChild(lightsnowNode);
            }

            if (heavyrainB == true)
            {
                XmlNode heavyrainNode = doc.CreateElement("heavyrain");
                heavyrainNode.AppendChild(doc.CreateTextNode("3"));
                documentNode.AppendChild(heavyrainNode);
                carlight = "ON";
                XmlNode lightNode = doc.CreateElement("Light");
                lightNode.AppendChild(doc.CreateTextNode(carlight));
                documentNode.AppendChild(lightNode);
            }
            if (heavysnowB == true)
            {
                XmlNode heavysnowNode = doc.CreateElement("heavysnow");
                heavysnowNode.AppendChild(doc.CreateTextNode("4"));
                documentNode.AppendChild(heavysnowNode);
                carlight = "ON";
                XmlNode lightNode = doc.CreateElement("Light");
                lightNode.AppendChild(doc.CreateTextNode(carlight));
                documentNode.AppendChild(lightNode);
            }
            if (overheatB == true)
            {
                XmlNode errorcodeNode = doc.CreateElement("errorcode");
                errorcodeNode.AppendChild(doc.CreateTextNode("1"));
                documentNode.AppendChild(errorcodeNode);

            }
            if (washerfluidB == true)
            {
                XmlNode errorcodeNode = doc.CreateElement("errorcode");
                errorcodeNode.AppendChild(doc.CreateTextNode("2"));
                documentNode.AppendChild(errorcodeNode);

            }
            if (tirepressureB == true)
            {
                XmlNode errorcodeNode = doc.CreateElement("errorcode");
                errorcodeNode.AppendChild(doc.CreateTextNode("3"));
                documentNode.AppendChild(errorcodeNode);

            }
            if (oilB == true)
            {
                XmlNode errorcodeNode = doc.CreateElement("errorcode");
                errorcodeNode.AppendChild(doc.CreateTextNode("4"));
                documentNode.AppendChild(errorcodeNode);

            }
            if (freeB == true)
            {
                XmlNode trafficNode = doc.CreateElement("trafficNode");
                trafficNode.AppendChild(doc.CreateTextNode("1"));
                documentNode.AppendChild(trafficNode);

            }
            if (lightB == true)
            {
                XmlNode trafficNode = doc.CreateElement("trafficNode");
                trafficNode.AppendChild(doc.CreateTextNode("2"));
                documentNode.AppendChild(trafficNode);

            }
            if ( mediumB== true)
            {
                XmlNode trafficNode = doc.CreateElement("trafficNode");
                trafficNode.AppendChild(doc.CreateTextNode("3"));
                documentNode.AppendChild(trafficNode);

            }
            if (heavyB == true)
            {
                XmlNode trafficNode = doc.CreateElement("trafficNode");
                trafficNode.AppendChild(doc.CreateTextNode("4"));
                documentNode.AppendChild(trafficNode);

            }
            doc.Save("test4.xml");

           







        }

        private void EXITBUTTON_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        

        

        

        

        





       

      

       
    }
}
