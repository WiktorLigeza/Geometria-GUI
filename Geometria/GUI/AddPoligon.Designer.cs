namespace GUI
{
    partial class AddPoligon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPoligon));
            this.labelNoE = new System.Windows.Forms.Label();
            this.textBoxVertices = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Pink = new System.Windows.Forms.CheckBox();
            this.Green = new System.Windows.Forms.CheckBox();
            this.Red = new System.Windows.Forms.CheckBox();
            this.own = new System.Windows.Forms.CheckBox();
            this.random = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelNoE
            // 
            this.labelNoE.AutoSize = true;
            this.labelNoE.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelNoE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNoE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNoE.Location = new System.Drawing.Point(8, 12);
            this.labelNoE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoE.Name = "labelNoE";
            this.labelNoE.Size = new System.Drawing.Size(230, 19);
            this.labelNoE.TabIndex = 30;
            this.labelNoE.Text = "Enter the number of vertices:";
            // 
            // textBoxVertices
            // 
            this.textBoxVertices.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVertices.Location = new System.Drawing.Point(242, 9);
            this.textBoxVertices.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVertices.Name = "textBoxVertices";
            this.textBoxVertices.Size = new System.Drawing.Size(74, 26);
            this.textBoxVertices.TabIndex = 29;
            this.textBoxVertices.TextChanged += new System.EventHandler(this.textBoxVertices_TextChanged);
            this.textBoxVertices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVertices_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(11, 483);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 28;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pink
            // 
            this.Pink.AutoSize = true;
            this.Pink.BackColor = System.Drawing.Color.Transparent;
            this.Pink.ForeColor = System.Drawing.Color.Fuchsia;
            this.Pink.Location = new System.Drawing.Point(11, 80);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(47, 17);
            this.Pink.TabIndex = 44;
            this.Pink.Text = "Pink";
            this.Pink.UseVisualStyleBackColor = false;
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.BackColor = System.Drawing.Color.Transparent;
            this.Green.ForeColor = System.Drawing.Color.Lime;
            this.Green.Location = new System.Drawing.Point(11, 57);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(55, 17);
            this.Green.TabIndex = 43;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = false;
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.BackColor = System.Drawing.Color.Transparent;
            this.Red.ForeColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(11, 34);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(46, 17);
            this.Red.TabIndex = 42;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = false;
            // 
            // own
            // 
            this.own.AutoSize = true;
            this.own.BackColor = System.Drawing.Color.Transparent;
            this.own.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.own.Location = new System.Drawing.Point(321, 9);
            this.own.Name = "own";
            this.own.Size = new System.Drawing.Size(48, 17);
            this.own.TabIndex = 45;
            this.own.Text = "Own";
            this.own.UseVisualStyleBackColor = false;
            this.own.CheckedChanged += new System.EventHandler(this.own_CheckedChanged);
            // 
            // random
            // 
            this.random.AutoSize = true;
            this.random.BackColor = System.Drawing.Color.Transparent;
            this.random.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.random.Location = new System.Drawing.Point(375, 9);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(66, 17);
            this.random.TabIndex = 46;
            this.random.Text = "Random";
            this.random.UseVisualStyleBackColor = false;
            this.random.CheckedChanged += new System.EventHandler(this.random_CheckedChanged);
            // 
            // AddPoligon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(575, 535);
            this.Controls.Add(this.random);
            this.Controls.Add(this.own);
            this.Controls.Add(this.Pink);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.labelNoE);
            this.Controls.Add(this.textBoxVertices);
            this.Controls.Add(this.button1);
            this.Name = "AddPoligon";
            this.Text = "AddPoligon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoE;
        private System.Windows.Forms.TextBox textBoxVertices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Pink;
        private System.Windows.Forms.CheckBox Green;
        private System.Windows.Forms.CheckBox Red;
        private System.Windows.Forms.CheckBox own;
        private System.Windows.Forms.CheckBox random;
    }
}