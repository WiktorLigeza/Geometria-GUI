namespace GUI
{
    partial class AddLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLine));
            this.Pink = new System.Windows.Forms.CheckBox();
            this.Green = new System.Windows.Forms.CheckBox();
            this.Red = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.P1X = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.P1Y = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.P2X = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.P2Y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usingSLE = new System.Windows.Forms.CheckBox();
            this.usingCoordinates = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pink
            // 
            this.Pink.AutoSize = true;
            this.Pink.BackColor = System.Drawing.Color.Transparent;
            this.Pink.ForeColor = System.Drawing.Color.Fuchsia;
            this.Pink.Location = new System.Drawing.Point(159, 294);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(47, 17);
            this.Pink.TabIndex = 21;
            this.Pink.Text = "Pink";
            this.Pink.UseVisualStyleBackColor = false;
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.BackColor = System.Drawing.Color.Transparent;
            this.Green.ForeColor = System.Drawing.Color.Lime;
            this.Green.Location = new System.Drawing.Point(80, 294);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(55, 17);
            this.Green.TabIndex = 20;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = false;
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.BackColor = System.Drawing.Color.Transparent;
            this.Red.ForeColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(11, 294);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(46, 17);
            this.Red.TabIndex = 19;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(54, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Controls.Add(this.usingCoordinates);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.P1X);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.P1Y);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.P2X);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.P2Y);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(10, 137);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(196, 141);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Points coordinates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(117, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "y:";
            // 
            // P1X
            // 
            this.P1X.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.P1X.Location = new System.Drawing.Point(81, 35);
            this.P1X.Margin = new System.Windows.Forms.Padding(2);
            this.P1X.Name = "P1X";
            this.P1X.Size = new System.Drawing.Size(32, 26);
            this.P1X.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(53, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "x:";
            // 
            // P1Y
            // 
            this.P1Y.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.P1Y.Location = new System.Drawing.Point(145, 35);
            this.P1Y.Margin = new System.Windows.Forms.Padding(2);
            this.P1Y.Name = "P1Y";
            this.P1Y.Size = new System.Drawing.Size(32, 26);
            this.P1Y.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Desktop;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(117, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "y:";
            // 
            // P2X
            // 
            this.P2X.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.P2X.Location = new System.Drawing.Point(81, 73);
            this.P2X.Margin = new System.Windows.Forms.Padding(2);
            this.P2X.Name = "P2X";
            this.P2X.Size = new System.Drawing.Size(32, 26);
            this.P2X.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Desktop;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(53, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "x:";
            // 
            // P2Y
            // 
            this.P2Y.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.P2Y.Location = new System.Drawing.Point(145, 73);
            this.P2Y.Margin = new System.Windows.Forms.Padding(2);
            this.P2Y.Name = "P2Y";
            this.P2Y.Size = new System.Drawing.Size(32, 26);
            this.P2Y.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(4, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "P1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Desktop;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(4, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "P2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Controls.Add(this.usingSLE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxB);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(179, 84);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(81, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "b:";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxA.Location = new System.Drawing.Point(45, 23);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(32, 26);
            this.textBoxA.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(17, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "a:";
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxB.Location = new System.Drawing.Point(109, 23);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(32, 26);
            this.textBoxB.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "OR";
            // 
            // usingSLE
            // 
            this.usingSLE.AutoSize = true;
            this.usingSLE.BackColor = System.Drawing.Color.Transparent;
            this.usingSLE.ForeColor = System.Drawing.Color.White;
            this.usingSLE.Location = new System.Drawing.Point(21, 57);
            this.usingSLE.Name = "usingSLE";
            this.usingSLE.Size = new System.Drawing.Size(102, 22);
            this.usingSLE.TabIndex = 28;
            this.usingSLE.Text = "Using SLE";
            this.usingSLE.UseVisualStyleBackColor = false;
            // 
            // usingCoordinates
            // 
            this.usingCoordinates.AutoSize = true;
            this.usingCoordinates.BackColor = System.Drawing.Color.Transparent;
            this.usingCoordinates.ForeColor = System.Drawing.Color.White;
            this.usingCoordinates.Location = new System.Drawing.Point(5, 114);
            this.usingCoordinates.Name = "usingCoordinates";
            this.usingCoordinates.Size = new System.Drawing.Size(153, 22);
            this.usingCoordinates.TabIndex = 29;
            this.usingCoordinates.Text = "Using coordinates";
            this.usingCoordinates.UseVisualStyleBackColor = false;
            // 
            // AddLinecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(553, 386);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Pink);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Name = "AddLinecs";
            this.Text = "AddLinecs";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Pink;
        private System.Windows.Forms.CheckBox Green;
        private System.Windows.Forms.CheckBox Red;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox P1X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox P1Y;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox P2X;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox P2Y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox usingCoordinates;
        private System.Windows.Forms.CheckBox usingSLE;
    }
}