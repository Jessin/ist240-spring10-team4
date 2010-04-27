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
        public static library_dll.Entities.HUDD CarHud = new library_dll.Entities.HUDD();
        public static int CarErrorCode;
        public static int trafficcode;
        public static int vehspeed = 0, minspeed = 0;
        public static Boolean decspeed = false;



        private void DisplayHUD_Load_1(object sender, EventArgs e)
        {
            library_dll.Entities.utility.Timer(1000);

            timer1.Enabled = true;
            timer1.Interval = 100;

        }


        public DisplayHUD()
        {
            InitializeComponent();
            
            
        }
        
        private void DisplayHUD_Load(object sender, EventArgs e)
        {
            //library_dll.Entities.utility.Timer(1000);
            
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
            
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            int returnSpeed = utility.RandomNumber(5, 100);
            textSpeed.Text = Convert.ToString(returnSpeed);
        }

        private void txtLights_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void txtWipers_TextChanged(object sender, EventArgs e)
        {
          
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            double fuel = 20.5;
            double resultFuel;
            resultFuel = --fuel;
            textFuel.Text = Convert.ToString(resultFuel);

            int dist = 34567;
            int resultDist;
            resultDist = ++dist;
            //Talk to Joe about how to increment using time
            txtDistance.Text = Convert.ToString(resultDist);

            if (utility.Weather == 0)
                txtWipers.Text = "OFF";
            if (utility.Weather == 1)
                txtWipers.Text = "LOW";
            if (utility.Weather == 2)
                txtWipers.Text = "LOW";
            if (utility.Weather == 3)
                txtWipers.Text = "HIGH";
            if (utility.Weather == 4)
                txtWipers.Text = "HIGH";

            txtLights.Text = CarHud.Light;
            Statustxt.Text = Convert.ToString(CarErrorCode);
            if (CarErrorCode == 0)
                Statustxt.Text = "No Issues";
            if (CarErrorCode == 1)
                Statustxt.Text = "Maintenance Required";
            if (CarErrorCode == 2)
                Statustxt.Text = "Maintenance Required";
            if (CarErrorCode == 3)
                Statustxt.Text = "Maintenance Required";
            if (CarErrorCode == 4)
                Statustxt.Text = "Maintenance Required";
            if (CarErrorCode == 5)
                Statustxt.Text = "Maintenance Required";
            if (CarErrorCode == 6)
                Statustxt.Text = "Maintenance Required";
            if (CarErrorCode == 7)
                Statustxt.Text = "Maintenance Required";


            if (trafficcode == 1)
            {

                vehspeed = 65;
                decspeed = true;
                if (decspeed == true)
                {
                    if (minspeed < vehspeed)
                    {
                        TmrSpdInc.Enabled = true;
                    }

                    //minspeed = 65;
                }

            }
            else if (trafficcode == 2)
            {
                vehspeed = 45;
                decspeed = true;
                if (decspeed == true)
                {
                    if (minspeed > vehspeed)
                    {

                        TmrSpdDec.Enabled = true;
                        //decspeed = false;

                    }
                    if (minspeed < vehspeed)
                    {
                        TmrSpdInc.Enabled = true;
                    }
                }
            }
            if (trafficcode == 3)
                
            vehspeed = 30;
            decspeed = true;
            if (decspeed == true)
            {

                if (minspeed > vehspeed)
                {
                    decspeed = true;
                    TmrSpdDec.Enabled = true;
                    //decspeed = false;

                }

                if (minspeed < vehspeed)
                {
                    TmrSpdInc.Enabled = true;
                }
            }
            if (trafficcode == 4)
                
            vehspeed = 10;
            decspeed = true;
            if (decspeed == true)
            {
                if (minspeed > vehspeed)
                {

                    TmrSpdDec.Enabled = true;
                   // decspeed = false;

                }

                if (minspeed < vehspeed)
                {
                    TmrSpdInc.Enabled = true;
                }
            }

        }

        private void TmrSpdDec_Tick(object sender, EventArgs e)
        {
            if (minspeed >= (vehspeed + 1))
            {
                minspeed = minspeed - 1;
                textSpeed.Text = Convert.ToString(minspeed);
            }
            else
            {
                TmrSpdDec.Enabled = false;
            }
        }

        private void TmrSpdInc_Tick(object sender, EventArgs e)
        {
            if (minspeed <= (vehspeed - 1))
            {
                minspeed = minspeed + 1;
                textSpeed.Text = Convert.ToString(minspeed);
            }
            else
            {
                TmrSpdDec.Enabled = false;
            }

        }

        }


    }
