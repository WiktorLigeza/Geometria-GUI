namespace GUI
{
    partial class NEAREST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NEAREST));
            this.groupBoxElements = new System.Windows.Forms.GroupBox();
            this.labelNoE = new System.Windows.Forms.Label();
            this.textBoxElemetns = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxElements.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxElements
            // 
            this.groupBoxElements.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBoxElements.Controls.Add(this.labelNoE);
            this.groupBoxElements.Controls.Add(this.textBoxElemetns);
            this.groupBoxElements.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxElements.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxElements.Location = new System.Drawing.Point(189, 28);
            this.groupBoxElements.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxElements.Name = "groupBoxElements";
            this.groupBoxElements.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxElements.Size = new System.Drawing.Size(289, 72);
            this.groupBoxElements.TabIndex = 8;
            this.groupBoxElements.TabStop = false;
            this.groupBoxElements.Text = "Elements";
            // 
            // labelNoE
            // 
            this.labelNoE.AutoSize = true;
            this.labelNoE.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelNoE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNoE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNoE.Location = new System.Drawing.Point(4, 32);
            this.labelNoE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoE.Name = "labelNoE";
            this.labelNoE.Size = new System.Drawing.Size(211, 19);
            this.labelNoE.TabIndex = 5;
            this.labelNoE.Text = "Enter number of elements:";
            // 
            // textBoxElemetns
            // 
            this.textBoxElemetns.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxElemetns.Location = new System.Drawing.Point(219, 29);
            this.textBoxElemetns.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxElemetns.Name = "textBoxElemetns";
            this.textBoxElemetns.Size = new System.Drawing.Size(49, 26);
            this.textBoxElemetns.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Controls.Add(this.labelY);
            this.groupBox1.Controls.Add(this.textBoxX);
            this.groupBox1.Controls.Add(this.labelX);
            this.groupBox1.Controls.Add(this.textBoxY);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(45, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(140, 72);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinates";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelY.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelY.Location = new System.Drawing.Point(62, 34);
            this.labelY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(24, 19);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "y:";
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxX.Location = new System.Drawing.Point(26, 32);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(32, 26);
            this.textBoxX.TabIndex = 1;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelX.Location = new System.Drawing.Point(1, 34);
            this.labelX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(24, 19);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "x:";
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxY.Location = new System.Drawing.Point(88, 32);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(32, 26);
            this.textBoxY.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(482, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NEAREST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(640, 139);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxElements);
            this.Controls.Add(this.groupBox1);
            this.Name = "NEAREST";
            this.Text = "FIND NEAREST";
            this.groupBoxElements.ResumeLayout(false);
            this.groupBoxElements.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxElements;
        private System.Windows.Forms.Label labelNoE;
        private System.Windows.Forms.TextBox textBoxElemetns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button button1;
    }
}