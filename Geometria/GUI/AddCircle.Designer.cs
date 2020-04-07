namespace GUI
{
    partial class AddCircle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCircle));
            this.button1 = new System.Windows.Forms.Button();
            this.Pink = new System.Windows.Forms.CheckBox();
            this.Green = new System.Windows.Forms.CheckBox();
            this.Red = new System.Windows.Forms.CheckBox();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(11, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 29;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pink
            // 
            this.Pink.AutoSize = true;
            this.Pink.BackColor = System.Drawing.Color.Transparent;
            this.Pink.ForeColor = System.Drawing.Color.Fuchsia;
            this.Pink.Location = new System.Drawing.Point(75, 39);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(47, 17);
            this.Pink.TabIndex = 47;
            this.Pink.Text = "Pink";
            this.Pink.UseVisualStyleBackColor = false;
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.BackColor = System.Drawing.Color.Transparent;
            this.Green.ForeColor = System.Drawing.Color.Lime;
            this.Green.Location = new System.Drawing.Point(142, 39);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(55, 17);
            this.Green.TabIndex = 46;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = false;
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.BackColor = System.Drawing.Color.Transparent;
            this.Red.ForeColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(11, 39);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(46, 17);
            this.Red.TabIndex = 45;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = false;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelY.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelY.Location = new System.Drawing.Point(71, 13);
            this.labelY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(24, 19);
            this.labelY.TabIndex = 53;
            this.labelY.Text = "y:";
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxX.Location = new System.Drawing.Point(35, 11);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(32, 26);
            this.textBoxX.TabIndex = 50;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelX.Location = new System.Drawing.Point(10, 13);
            this.labelX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(24, 19);
            this.labelX.TabIndex = 52;
            this.labelX.Text = "x:";
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxY.Location = new System.Drawing.Point(97, 11);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(32, 26);
            this.textBoxY.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(138, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "r:";
            // 
            // textBoxR
            // 
            this.textBoxR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxR.Location = new System.Drawing.Point(164, 11);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(32, 26);
            this.textBoxR.TabIndex = 54;
            this.textBoxR.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(581, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.Pink);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.button1);
            this.Name = "AddCircle";
            this.Text = "AddCircle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Pink;
        private System.Windows.Forms.CheckBox Green;
        private System.Windows.Forms.CheckBox Red;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxR;
    }
}