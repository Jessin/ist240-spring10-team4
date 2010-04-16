using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library_dll.Entities;
using System.Xml;

namespace Library_dll
{
    public class Worker
    {

        public static Radar ReadXMLRadar()
        {
            Radar rad = new Radar();
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("RAD_Config.xml");
                XmlNode nodeVar1 = xmlDoc.SelectSingleNode("/settings/" + "series");
                rad.Model = nodeVar1.InnerText;
                nodeVar1 = xmlDoc.SelectSingleNode("/settings/" + "series");
                rad.Seriers = nodeVar1.InnerText;
            }
            catch (Exception e)
            {
                //write e to log
            }
            return rad;
        }

        public static Comm ReadXMLComm()
        {
            Comm Comm1 = new Comm();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("COM_Config.xml");
            XmlNode nodeVar1 = xmlDoc.SelectSingleNode("/settings/" + "series");
            Comm1.Model = nodeVar1.InnerText;
            nodeVar1 = xmlDoc.SelectSingleNode("/settings/" + "series");
            Comm1.Seriers = nodeVar1.InnerText;
        }

        public static Missile ReadXMLMissle()
        {
            Missile miss = new Missile();
        }


    }
}
