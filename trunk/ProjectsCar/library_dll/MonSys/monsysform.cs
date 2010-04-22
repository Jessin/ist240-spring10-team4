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



            timer1.Enabled = true;
            timer1.Interval = 10;

            //try
            //{
            //    library_dll.Entities.HUDD CarHud = new library_dll.Entities.HUDD();
            //    library_dll.Entities.TestingSystem TS = new library_dll.Entities.TestingSystem();
            //    XmlReader reader = new XmlTextReader(@"../../../../CarTestingInfo.xml");
            //    XmlSerializer serializer = new XmlSerializer(typeof(library_dll.Entities.TestingSystem));
            //    TS = (library_dll.Entities.TestingSystem)serializer.Deserialize(reader);
            //    int testcode = Convert.ToInt16(TS.ErrorCode);
            //    if (ErrorCode == 1)
            //        textBox1.Text = "Engine Overheated";
            //    if (ErrorCode == 2)
            //        textBox2.Text = "Washer Fluid Low";
            //    if (ErrorCode == 3)
            //        textBox3.Text = "Tire Pressure Low";
            //    if (ErrorCode == 4)
            //        textBox4.Text = "Needs Oil Change";
            //}
            //catch (FileNotFoundException ex)
            //{
            //    MessageBox.Show(ex + "FILE NOT FOUND");
            //}
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (library_dll.Entities.utility.MonErrorCode == 0)
                errorCodeBox1.Text = "No Issues Found";
            else if (library_dll.Entities.utility.MonErrorCode == 1)
                errorCodeBox1.Text = " Over heat";

            

        }

        private void errorCodeBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
