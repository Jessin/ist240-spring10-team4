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


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        library_dll.Entities.HUD CARHUD = new library_dll.Entities.HUD();
        library_dll.Entities.MONSystem CARMON = new library_dll.Entities.MONSystem();

        

        private void StartButton_Click(object sender, EventArgs e)
        {

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

            XmlAttribute speedAttribute = doc.CreateAttribute("Type");
            speedAttribute.Value = "Speed";
            speedNode.Attributes.Append(speedAttribute);
            documentNode.AppendChild(speedNode);
            
            XmlNode directionNode = doc.CreateElement("direction");
            directionNode.AppendChild(doc.CreateTextNode("North"));

            XmlAttribute directionAttribute = doc.CreateAttribute("Type");
            directionAttribute.Value = "direction";
            directionNode.Attributes.Append(directionAttribute);
            documentNode.AppendChild(directionNode);

            XmlNode distanceNode = doc.CreateElement("distance");
            distanceNode.AppendChild(doc.CreateTextNode("500"));

            XmlAttribute distanceAttribute = doc.CreateAttribute("Type");
            distanceAttribute.Value = "distance";
            distanceNode.Attributes.Append(distanceAttribute);
            documentNode.AppendChild(distanceNode);

            XmlNode wiperspeedNode = doc.CreateElement("wiperspeed");
            wiperspeedNode.AppendChild(doc.CreateTextNode("0"));

            XmlAttribute wiperspeedAttribute = doc.CreateAttribute("Type");
            wiperspeedAttribute.Value = "wiperspeed";
            wiperspeedNode.Attributes.Append(wiperspeedAttribute);
            documentNode.AppendChild(wiperspeedNode);

            XmlNode lightNode = doc.CreateElement("light");
            lightNode.AppendChild(doc.CreateTextNode("OFF"));

            XmlAttribute lightAttribute = doc.CreateAttribute("light");
            lightAttribute.Value = "light";
            lightNode.Attributes.Append(lightAttribute);
            documentNode.AppendChild(lightNode);

            doc.Save("test.xml");
            
            
        


            

            




            
        }

        private void DayButton_CheckedChanged(object sender, EventArgs e)
        {
            CARHUD.LIGHT = "OFF";
        
        }

        private void NightButton_CheckedChanged(object sender, EventArgs e)
        {
            CARHUD.LIGHT = "ON";

        }

        private void LightRainButton_CheckedChanged(object sender, EventArgs e)
        {
            CARHUD.Wiperspeed = 1;

        }

        private void LightSnowButton_CheckedChanged(object sender, EventArgs e)
        {
            CARHUD.Wiperspeed = 2;

        }

        private void HeavyRainButton_CheckedChanged(object sender, EventArgs e)
        {
            CARHUD.Wiperspeed = 4;
        }

        private void HeavySnowButton_CheckedChanged(object sender, EventArgs e)
        {
            CARHUD.Wiperspeed = 3;
        }

        private void OHeatButton_CheckedChanged(object sender, EventArgs e)
        {
            CARHUD.CarRepair = 1;
        }

        private void WFluidButton_CheckedChanged(object sender, EventArgs e)
        {
            CARHUD.CarRepair = 2;

        }

        private void TPressureButton_CheckedChanged(object sender, EventArgs e)
        {
            CARHUD.CarRepair = 3;
        }

        private void OilButton_CheckedChanged(object sender, EventArgs e)
        {
            CARHUD.CarRepair = 4;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void EXITBUTTON_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }





       

      

       
    }
}
