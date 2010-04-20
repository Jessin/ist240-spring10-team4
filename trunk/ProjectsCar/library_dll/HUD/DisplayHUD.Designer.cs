namespace HUD
{
    partial class DisplayHUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.boxDistance = new System.Windows.Forms.GroupBox();
            this.lblMiles = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.boxFuel = new System.Windows.Forms.GroupBox();
            this.lblFuel = new System.Windows.Forms.Label();
            this.textFuel = new System.Windows.Forms.TextBox();
            this.boxSpeed = new System.Windows.Forms.GroupBox();
            this.lblMPH = new System.Windows.Forms.Label();
            this.textSpeed = new System.Windows.Forms.TextBox();
            this.boxStatus = new System.Windows.Forms.GroupBox();
            this.Statustxt = new System.Windows.Forms.TextBox();
            this.txtWipers = new System.Windows.Forms.TextBox();
            this.txtLights = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWipers = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.boxDistance.SuspendLayout();
            this.boxFuel.SuspendLayout();
            this.boxSpeed.SuspendLayout();
            this.boxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMARTCAR";
            // 
            // boxDistance
            // 
            this.boxDistance.Controls.Add(this.lblMiles);
            this.boxDistance.Controls.Add(this.txtDistance);
            this.boxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDistance.Location = new System.Drawing.Point(13, 13);
            this.boxDistance.Name = "boxDistance";
            this.boxDistance.Size = new System.Drawing.Size(200, 100);
            this.boxDistance.TabIndex = 3;
            this.boxDistance.TabStop = false;
            this.boxDistance.Text = "DISTANCE";
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiles.Location = new System.Drawing.Point(134, 50);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(45, 16);
            this.lblMiles.TabIndex = 1;
            this.lblMiles.Text = "miles";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(28, 41);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 29);
            this.txtDistance.TabIndex = 0;
            this.txtDistance.TextChanged += new System.EventHandler(this.txtDistance_TextChanged);
            // 
            // boxFuel
            // 
            this.boxFuel.Controls.Add(this.lblFuel);
            this.boxFuel.Controls.Add(this.textFuel);
            this.boxFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFuel.Location = new System.Drawing.Point(13, 149);
            this.boxFuel.Name = "boxFuel";
            this.boxFuel.Size = new System.Drawing.Size(200, 110);
            this.boxFuel.TabIndex = 3;
            this.boxFuel.TabStop = false;
            this.boxFuel.Text = "FUEL";
            this.boxFuel.UseCompatibleTextRendering = true;
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuel.Location = new System.Drawing.Point(109, 59);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(59, 16);
            this.lblFuel.TabIndex = 1;
            this.lblFuel.Text = "gallons";
            // 
            // textFuel
            // 
            this.textFuel.Location = new System.Drawing.Point(28, 46);
            this.textFuel.Name = "textFuel";
            this.textFuel.Size = new System.Drawing.Size(55, 29);
            this.textFuel.TabIndex = 1;
            this.textFuel.TextChanged += new System.EventHandler(this.textFuel_TextChanged);
            // 
            // boxSpeed
            // 
            this.boxSpeed.Controls.Add(this.lblMPH);
            this.boxSpeed.Controls.Add(this.textSpeed);
            this.boxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSpeed.Location = new System.Drawing.Point(233, 13);
            this.boxSpeed.Name = "boxSpeed";
            this.boxSpeed.Size = new System.Drawing.Size(200, 100);
            this.boxSpeed.TabIndex = 3;
            this.boxSpeed.TabStop = false;
            this.boxSpeed.Text = "SPEED";
            this.boxSpeed.Enter += new System.EventHandler(this.boxSpeed_Enter);
            // 
            // lblMPH
            // 
            this.lblMPH.AutoSize = true;
            this.lblMPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPH.Location = new System.Drawing.Point(136, 50);
            this.lblMPH.Name = "lblMPH";
            this.lblMPH.Size = new System.Drawing.Size(37, 16);
            this.lblMPH.TabIndex = 1;
            this.lblMPH.Text = "mph";
            // 
            // textSpeed
            // 
            this.textSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSpeed.Location = new System.Drawing.Point(48, 41);
            this.textSpeed.Name = "textSpeed";
            this.textSpeed.Size = new System.Drawing.Size(82, 26);
            this.textSpeed.TabIndex = 0;
            this.textSpeed.TextChanged += new System.EventHandler(this.textSpeed_TextChanged);
            // 
            // boxStatus
            // 
            this.boxStatus.Controls.Add(this.txtWipers);
            this.boxStatus.Controls.Add(this.txtLights);
            this.boxStatus.Controls.Add(this.label2);
            this.boxStatus.Controls.Add(this.lblWipers);
            this.boxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxStatus.Location = new System.Drawing.Point(233, 149);
            this.boxStatus.Name = "boxStatus";
            this.boxStatus.Size = new System.Drawing.Size(200, 110);
            this.boxStatus.TabIndex = 3;
            this.boxStatus.TabStop = false;
            this.boxStatus.Text = "STATUS";
            // 
            // Statustxt
            // 
            this.Statustxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statustxt.Location = new System.Drawing.Point(125, 272);
            this.Statustxt.Name = "Statustxt";
            this.Statustxt.Size = new System.Drawing.Size(190, 26);
            this.Statustxt.TabIndex = 2;
            this.Statustxt.TextChanged += new System.EventHandler(this.Statustxt_TextChanged);
            // 
            // txtWipers
            // 
            this.txtWipers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWipers.Location = new System.Drawing.Point(117, 49);
            this.txtWipers.Name = "txtWipers";
            this.txtWipers.Size = new System.Drawing.Size(54, 26);
            this.txtWipers.TabIndex = 1;
            this.txtWipers.TextChanged += new System.EventHandler(this.txtWipers_TextChanged);
            // 
            // txtLights
            // 
            this.txtLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLights.Location = new System.Drawing.Point(28, 49);
            this.txtLights.Name = "txtLights";
            this.txtLights.Size = new System.Drawing.Size(54, 26);
            this.txtLights.TabIndex = 1;
            this.txtLights.TextChanged += new System.EventHandler(this.txtLights_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Car Status: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lights";
            // 
            // lblWipers
            // 
            this.lblWipers.AutoSize = true;
            this.lblWipers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWipers.Location = new System.Drawing.Point(113, 25);
            this.lblWipers.Name = "lblWipers";
            this.lblWipers.Size = new System.Drawing.Size(64, 20);
            this.lblWipers.TabIndex = 0;
            this.lblWipers.Text = "Wipers";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(350, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DisplayHUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 319);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Statustxt);
            this.Controls.Add(this.boxStatus);
            this.Controls.Add(this.boxSpeed);
            this.Controls.Add(this.boxFuel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxDistance);
            this.Controls.Add(this.label1);
            this.Name = "DisplayHUD";
            this.Text = "HUD";
            this.Load += new System.EventHandler(this.DisplayHUD_Load_1);
            this.boxDistance.ResumeLayout(false);
            this.boxDistance.PerformLayout();
            this.boxFuel.ResumeLayout(false);
            this.boxFuel.PerformLayout();
            this.boxSpeed.ResumeLayout(false);
            this.boxSpeed.PerformLayout();
            this.boxStatus.ResumeLayout(false);
            this.boxStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox boxDistance;
        private System.Windows.Forms.GroupBox boxFuel;
        private System.Windows.Forms.GroupBox boxSpeed;
        private System.Windows.Forms.GroupBox boxStatus;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Label lblMPH;
        private System.Windows.Forms.TextBox textSpeed;
        private System.Windows.Forms.Label lblWipers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.TextBox textFuel;
        private System.Windows.Forms.TextBox txtWipers;
        private System.Windows.Forms.TextBox txtLights;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Statustxt;
        private System.Windows.Forms.Button btnExit;
    }
}

