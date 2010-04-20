using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using library_dll.Entities;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Timers;



namespace HUD
{

    public partial class DisplayHUD : Form
    {
        
        
        

        public static void readAgian()
        {
            try
            {
                library_dll.Entities.HUDD CarHud = new library_dll.Entities.HUDD();
                library_dll.Entities.TestingSystem TS = new library_dll.Entities.TestingSystem();
                XmlReader reader = new XmlTextReader(@"C:\Documents and Settings\jpj5048\Desktop\NOW\New Folder\New Folder\ProjectsCar\CarTestingInfo.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(library_dll.Entities.TestingSystem));
                TS = (library_dll.Entities.TestingSystem)serializer.Deserialize(reader);
                CarHud.Light = TS.Light;
                
                
                MessageBox.Show(TS.Light);
                //int currentdirection = Convert.ToInt16(TS.DirectionCode);
                //MessageBox.Show(Convert.ToString(currentdirection));
                reader.Close();



            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex + "FILE NOT FOUND");
            }
        }

        private void DisplayHUD_Load_1(object sender, EventArgs e)
        {
            library_dll.Entities.utility.Timer(1000);
            

        }
        public DisplayHUD()
        {
            InitializeComponent();
        }
        
        private void DisplayHUD_Load(object sender, EventArgs e)
        {
            
        }

        private void textFuel_TextChanged(object sender, EventArgs e)
        {
            double fuel = 20.5;
            double resultFuel;
            resultFuel = --fuel;
            textFuel.Text = Convert.ToString(resultFuel);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        
        {
            //See if we can make a grpahical representaiton of fuel by percentage of fuel remaining

        }

        private void textSpeed_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void txtDistance_TextChanged(object sender, EventArgs e)
        {
            double dist;
            dist =+ 1;
            //Talk to Joe about how to increment using time
            txtDistance.Text = Convert.ToString(dist);
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            int returnSpeed = utility.RandomNumber(5, 100);
            textSpeed.Text = Convert.ToString(returnSpeed);
        }

        private void txtLights_TextChanged(object sender, EventArgs e)
        {
             
           
            //if (TestingSystem.Weather.)
            //{
            //   txtLights.Text = "ON";
            //}
            //if (weatherCode == 2)
            //{
            //    txtLights.Text = "ON";
            //}
            //if (weatherCode == 3)
            //{
            //    txtLights.Text = "ON";
            //}
            //if (weatherCode == 4)
            //{
            //    txtLights.Text = "ON";
            //}
            
            //else
            //{
            //    txtLights.Text = "OFF";
            //}
        }

        private void txtWipers_TextChanged(object sender, EventArgs e)
        {
            //if (weatherCode == 1)
            //{
            //    txtWipers.Text = "ON";
            //}
            //if (weatherCode == 2)
            //{
            //    txtWipers.Text = "ON";
            //}
            //if (weatherCode == 3)
            //{
            //    txtWipers.Text = "ON";
            //}
            //if (weatherCode == 4)
            //{
            //    txtWipers.Text = "ON";
            //}

            //else
            //{
            //    txtWipers.Text = "OFF";
            //}
        }

       

        private void boxSpeed_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Statustxt_TextChanged(object sender, EventArgs e)
        {

        }

        }


    }
