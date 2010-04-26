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

namespace MonSys
{
    public partial class MonSysForm : Form
    {
        public MonSysForm()
        {
            InitializeComponent();
        }

        private void MonSysForm_Load(object sender, EventArgs e)
        {

            library_dll.Entities.utility.Timer(1000);


            errorCodeBox1.Enabled = false;
            timer1.Enabled = true;
            timer1.Interval = 100;

           
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (library_dll.Entities.utility.MonErrorCode == 0)
            {
                errorCodeBox2.Visible = false;
                errorCodeBox2.Enabled = false;
                errorCodeBox1.Visible = true;
                errorCodeBox1.Enabled = true;
                errorCodeBox1.Text = "No Issues Found";
            }

            else if (library_dll.Entities.utility.MonErrorCode == 1)
            {
                errorCodeBox2.Visible = false;
                errorCodeBox2.Enabled = false;
                errorCodeBox1.Visible = true;
                errorCodeBox1.Enabled = true;
                errorCodeBox1.Text = " Engine Overheat";
            }
            else if (library_dll.Entities.utility.MonErrorCode == 2)
            {
                errorCodeBox2.Visible = false;
                errorCodeBox2.Enabled = false;
                errorCodeBox1.Visible = true;
                errorCodeBox1.Enabled = true;
                errorCodeBox1.Text = "Low Washer Fluid";
            }
            else if (library_dll.Entities.utility.MonErrorCode == 3)
            {
                errorCodeBox2.Visible = false;
                errorCodeBox2.Enabled = false;
                errorCodeBox1.Visible = true;
                errorCodeBox1.Enabled = true;
                errorCodeBox1.Text = "Needs Oil change";
            }
            else if (library_dll.Entities.utility.MonErrorCode == 4)
            {
                errorCodeBox2.Visible = true;
                errorCodeBox2.Enabled = true;
                errorCodeBox2.Text = "Low Tire Pressure in front Right Wheel";
            }
            else if (library_dll.Entities.utility.MonErrorCode == 5)
            {
                errorCodeBox2.Visible = true;
                errorCodeBox2.Enabled = true;
                errorCodeBox2.Text = "Low Tire Pressure in front Left Wheel";
            }
            else if (library_dll.Entities.utility.MonErrorCode == 6)
            {
                errorCodeBox2.Visible = true;
                errorCodeBox2.Enabled = true;
                errorCodeBox2.Text = "Low Tire Pressure in back Right Wheel";
            }
            else if (library_dll.Entities.utility.MonErrorCode == 7)
            {
                errorCodeBox2.Visible = true;
                errorCodeBox2.Enabled = true;
                errorCodeBox2.Text = "Low Tire Pressure in back Left Wheel";
            }
            if (library_dll.Entities.utility.DirectCode == 0)
               textBox1.Text  = "North";
            else if (library_dll.Entities.utility.DirectCode == 1)
                textBox1.Text = "NorthEast";
            else if (library_dll.Entities.utility.DirectCode == 2)
                textBox1.Text = "East";
            else if (library_dll.Entities.utility.DirectCode == 3)
                textBox1.Text = "SouthEast";
            else if (library_dll.Entities.utility.DirectCode == 4)
                textBox1.Text = "South";
            else if (library_dll.Entities.utility.DirectCode == 5)
                textBox1.Text = "SouthWest";
            else if (library_dll.Entities.utility.DirectCode == 6)
                textBox1.Text = "West";
            else if (library_dll.Entities.utility.DirectCode == 7)
                textBox1.Text = "NorthWest";

                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
