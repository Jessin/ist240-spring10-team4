namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TestButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearButton1 = new System.Windows.Forms.RadioButton();
            this.HeavySnowButton = new System.Windows.Forms.RadioButton();
            this.HeavyRainButton = new System.Windows.Forms.RadioButton();
            this.LightSnowButton = new System.Windows.Forms.RadioButton();
            this.LightRainButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OilButton = new System.Windows.Forms.RadioButton();
            this.TPressureButton = new System.Windows.Forms.RadioButton();
            this.WFluidButton = new System.Windows.Forms.RadioButton();
            this.OHeatButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NightButton = new System.Windows.Forms.RadioButton();
            this.DayButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.HeavyTraffButton = new System.Windows.Forms.RadioButton();
            this.MediumTraffButton = new System.Windows.Forms.RadioButton();
            this.LightTraffButton = new System.Windows.Forms.RadioButton();
            this.NoTraffButton = new System.Windows.Forms.RadioButton();
            this.EXITBUTTON = new System.Windows.Forms.Button();
            this.NoProblemButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(101, 275);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(122, 45);
            this.TestButton.TabIndex = 0;
            this.TestButton.Text = "TEST";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EXTERIOR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearButton1);
            this.groupBox1.Controls.Add(this.HeavySnowButton);
            this.groupBox1.Controls.Add(this.HeavyRainButton);
            this.groupBox1.Controls.Add(this.LightSnowButton);
            this.groupBox1.Controls.Add(this.LightRainButton);
            this.groupBox1.Location = new System.Drawing.Point(105, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weather";
            // 
            // ClearButton1
            // 
            this.ClearButton1.AutoSize = true;
            this.ClearButton1.Location = new System.Drawing.Point(7, 16);
            this.ClearButton1.Name = "ClearButton1";
            this.ClearButton1.Size = new System.Drawing.Size(49, 17);
            this.ClearButton1.TabIndex = 4;
            this.ClearButton1.TabStop = true;
            this.ClearButton1.Text = "Clear";
            this.ClearButton1.UseVisualStyleBackColor = true;
            this.ClearButton1.CheckedChanged += new System.EventHandler(this.ClearButton1_CheckedChanged);
            // 
            // HeavySnowButton
            // 
            this.HeavySnowButton.AutoSize = true;
            this.HeavySnowButton.Location = new System.Drawing.Point(7, 108);
            this.HeavySnowButton.Name = "HeavySnowButton";
            this.HeavySnowButton.Size = new System.Drawing.Size(83, 17);
            this.HeavySnowButton.TabIndex = 3;
            this.HeavySnowButton.TabStop = true;
            this.HeavySnowButton.Text = "HeavySnow";
            this.HeavySnowButton.UseVisualStyleBackColor = true;
            this.HeavySnowButton.CheckedChanged += new System.EventHandler(this.HeavySnowButton_CheckedChanged);
            // 
            // HeavyRainButton
            // 
            this.HeavyRainButton.AutoSize = true;
            this.HeavyRainButton.Location = new System.Drawing.Point(7, 84);
            this.HeavyRainButton.Name = "HeavyRainButton";
            this.HeavyRainButton.Size = new System.Drawing.Size(78, 17);
            this.HeavyRainButton.TabIndex = 2;
            this.HeavyRainButton.TabStop = true;
            this.HeavyRainButton.Text = "HeavyRain";
            this.HeavyRainButton.UseVisualStyleBackColor = true;
            this.HeavyRainButton.CheckedChanged += new System.EventHandler(this.HeavyRainButton_CheckedChanged);
            // 
            // LightSnowButton
            // 
            this.LightSnowButton.AutoSize = true;
            this.LightSnowButton.Location = new System.Drawing.Point(7, 60);
            this.LightSnowButton.Name = "LightSnowButton";
            this.LightSnowButton.Size = new System.Drawing.Size(75, 17);
            this.LightSnowButton.TabIndex = 1;
            this.LightSnowButton.TabStop = true;
            this.LightSnowButton.Text = "LightSnow";
            this.LightSnowButton.UseVisualStyleBackColor = true;
            this.LightSnowButton.CheckedChanged += new System.EventHandler(this.LightSnowButton_CheckedChanged);
            // 
            // LightRainButton
            // 
            this.LightRainButton.AutoSize = true;
            this.LightRainButton.Location = new System.Drawing.Point(7, 37);
            this.LightRainButton.Name = "LightRainButton";
            this.LightRainButton.Size = new System.Drawing.Size(70, 17);
            this.LightRainButton.TabIndex = 0;
            this.LightRainButton.TabStop = true;
            this.LightRainButton.Text = "LightRain";
            this.LightRainButton.UseVisualStyleBackColor = true;
            this.LightRainButton.CheckedChanged += new System.EventHandler(this.LightRainButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NoProblemButton);
            this.groupBox2.Controls.Add(this.OilButton);
            this.groupBox2.Controls.Add(this.TPressureButton);
            this.groupBox2.Controls.Add(this.WFluidButton);
            this.groupBox2.Controls.Add(this.OHeatButton);
            this.groupBox2.Location = new System.Drawing.Point(249, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car";
            // 
            // OilButton
            // 
            this.OilButton.AutoSize = true;
            this.OilButton.Location = new System.Drawing.Point(7, 108);
            this.OilButton.Name = "OilButton";
            this.OilButton.Size = new System.Drawing.Size(37, 17);
            this.OilButton.TabIndex = 3;
            this.OilButton.TabStop = true;
            this.OilButton.Text = "Oil";
            this.OilButton.UseVisualStyleBackColor = true;
            this.OilButton.CheckedChanged += new System.EventHandler(this.OilButton_CheckedChanged);
            // 
            // TPressureButton
            // 
            this.TPressureButton.AutoSize = true;
            this.TPressureButton.Location = new System.Drawing.Point(7, 86);
            this.TPressureButton.Name = "TPressureButton";
            this.TPressureButton.Size = new System.Drawing.Size(84, 17);
            this.TPressureButton.TabIndex = 2;
            this.TPressureButton.TabStop = true;
            this.TPressureButton.Text = "TirePressure";
            this.TPressureButton.UseVisualStyleBackColor = true;
            this.TPressureButton.CheckedChanged += new System.EventHandler(this.TPressureButton_CheckedChanged);
            // 
            // WFluidButton
            // 
            this.WFluidButton.AutoSize = true;
            this.WFluidButton.Location = new System.Drawing.Point(7, 63);
            this.WFluidButton.Name = "WFluidButton";
            this.WFluidButton.Size = new System.Drawing.Size(84, 17);
            this.WFluidButton.TabIndex = 1;
            this.WFluidButton.TabStop = true;
            this.WFluidButton.Text = "WasherFluid";
            this.WFluidButton.UseVisualStyleBackColor = true;
            this.WFluidButton.CheckedChanged += new System.EventHandler(this.WFluidButton_CheckedChanged);
            // 
            // OHeatButton
            // 
            this.OHeatButton.AutoSize = true;
            this.OHeatButton.Location = new System.Drawing.Point(7, 40);
            this.OHeatButton.Name = "OHeatButton";
            this.OHeatButton.Size = new System.Drawing.Size(71, 17);
            this.OHeatButton.TabIndex = 0;
            this.OHeatButton.TabStop = true;
            this.OHeatButton.Text = "OverHeat";
            this.OHeatButton.UseVisualStyleBackColor = true;
            this.OHeatButton.CheckedChanged += new System.EventHandler(this.OHeatButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "INTERIOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LIGHT";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NightButton);
            this.groupBox3.Controls.Add(this.DayButton);
            this.groupBox3.Location = new System.Drawing.Point(9, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 135);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SunLight";
            // 
            // NightButton
            // 
            this.NightButton.AutoSize = true;
            this.NightButton.Location = new System.Drawing.Point(3, 54);
            this.NightButton.Name = "NightButton";
            this.NightButton.Size = new System.Drawing.Size(50, 17);
            this.NightButton.TabIndex = 1;
            this.NightButton.TabStop = true;
            this.NightButton.Text = "Night";
            this.NightButton.UseVisualStyleBackColor = true;
            this.NightButton.CheckedChanged += new System.EventHandler(this.NightButton_CheckedChanged);
            // 
            // DayButton
            // 
            this.DayButton.AutoSize = true;
            this.DayButton.Location = new System.Drawing.Point(3, 30);
            this.DayButton.Name = "DayButton";
            this.DayButton.Size = new System.Drawing.Size(44, 17);
            this.DayButton.TabIndex = 0;
            this.DayButton.TabStop = true;
            this.DayButton.Text = "Day";
            this.DayButton.UseVisualStyleBackColor = true;
            this.DayButton.CheckedChanged += new System.EventHandler(this.DayButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TRAFFIC";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.HeavyTraffButton);
            this.groupBox4.Controls.Add(this.MediumTraffButton);
            this.groupBox4.Controls.Add(this.LightTraffButton);
            this.groupBox4.Controls.Add(this.NoTraffButton);
            this.groupBox4.Location = new System.Drawing.Point(403, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(139, 135);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Traffic";
            // 
            // HeavyTraffButton
            // 
            this.HeavyTraffButton.AutoSize = true;
            this.HeavyTraffButton.Location = new System.Drawing.Point(15, 101);
            this.HeavyTraffButton.Name = "HeavyTraffButton";
            this.HeavyTraffButton.Size = new System.Drawing.Size(56, 17);
            this.HeavyTraffButton.TabIndex = 3;
            this.HeavyTraffButton.TabStop = true;
            this.HeavyTraffButton.Text = "Heavy";
            this.HeavyTraffButton.UseVisualStyleBackColor = true;
            this.HeavyTraffButton.CheckedChanged += new System.EventHandler(this.HeavyTraffButton_CheckedChanged_1);
            // 
            // MediumTraffButton
            // 
            this.MediumTraffButton.AutoSize = true;
            this.MediumTraffButton.Location = new System.Drawing.Point(15, 78);
            this.MediumTraffButton.Name = "MediumTraffButton";
            this.MediumTraffButton.Size = new System.Drawing.Size(62, 17);
            this.MediumTraffButton.TabIndex = 2;
            this.MediumTraffButton.TabStop = true;
            this.MediumTraffButton.Text = "Medium";
            this.MediumTraffButton.UseVisualStyleBackColor = true;
            // 
            // LightTraffButton
            // 
            this.LightTraffButton.AutoSize = true;
            this.LightTraffButton.Location = new System.Drawing.Point(15, 54);
            this.LightTraffButton.Name = "LightTraffButton";
            this.LightTraffButton.Size = new System.Drawing.Size(48, 17);
            this.LightTraffButton.TabIndex = 1;
            this.LightTraffButton.TabStop = true;
            this.LightTraffButton.Text = "Light";
            this.LightTraffButton.UseVisualStyleBackColor = true;
            // 
            // NoTraffButton
            // 
            this.NoTraffButton.AutoSize = true;
            this.NoTraffButton.Location = new System.Drawing.Point(15, 30);
            this.NoTraffButton.Name = "NoTraffButton";
            this.NoTraffButton.Size = new System.Drawing.Size(46, 17);
            this.NoTraffButton.TabIndex = 0;
            this.NoTraffButton.TabStop = true;
            this.NoTraffButton.Text = "Free";
            this.NoTraffButton.UseVisualStyleBackColor = true;
            this.NoTraffButton.CheckedChanged += new System.EventHandler(this.NoTraffButton_CheckedChanged_1);
            // 
            // EXITBUTTON
            // 
            this.EXITBUTTON.Location = new System.Drawing.Point(278, 275);
            this.EXITBUTTON.Name = "EXITBUTTON";
            this.EXITBUTTON.Size = new System.Drawing.Size(109, 45);
            this.EXITBUTTON.TabIndex = 10;
            this.EXITBUTTON.Text = "EXIT";
            this.EXITBUTTON.UseVisualStyleBackColor = true;
            this.EXITBUTTON.Click += new System.EventHandler(this.EXITBUTTON_Click_1);
            // 
            // NoProblemButton
            // 
            this.NoProblemButton.AutoSize = true;
            this.NoProblemButton.Location = new System.Drawing.Point(7, 17);
            this.NoProblemButton.Name = "NoProblemButton";
            this.NoProblemButton.Size = new System.Drawing.Size(82, 17);
            this.NoProblemButton.TabIndex = 4;
            this.NoProblemButton.TabStop = true;
            this.NoProblemButton.Text = "NoProblems";
            this.NoProblemButton.UseVisualStyleBackColor = true;
            this.NoProblemButton.CheckedChanged += new System.EventHandler(this.NoProblemButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 365);
            this.Controls.Add(this.EXITBUTTON);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TestButton);
            this.Name = "Form1";
            this.Text = "TestingSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LightSnowButton;
        private System.Windows.Forms.RadioButton LightRainButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton OilButton;
        private System.Windows.Forms.RadioButton TPressureButton;
        private System.Windows.Forms.RadioButton WFluidButton;
        private System.Windows.Forms.RadioButton OHeatButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton NightButton;
        private System.Windows.Forms.RadioButton DayButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton HeavyTraffButton;
        private System.Windows.Forms.RadioButton MediumTraffButton;
        private System.Windows.Forms.RadioButton LightTraffButton;
        private System.Windows.Forms.RadioButton NoTraffButton;
        private System.Windows.Forms.RadioButton HeavySnowButton;
        private System.Windows.Forms.RadioButton HeavyRainButton;
        private System.Windows.Forms.Button EXITBUTTON;
        private System.Windows.Forms.RadioButton ClearButton1;
        private System.Windows.Forms.RadioButton NoProblemButton;
    }
}

