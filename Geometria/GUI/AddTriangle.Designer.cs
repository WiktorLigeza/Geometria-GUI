namespace GUI
{
    partial class AddTriangle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTriangle));
            this.P1Button = new System.Windows.Forms.Button();
            this.P2Button = new System.Windows.Forms.Button();
            this.P3Button = new System.Windows.Forms.Button();
            this.proceedButton = new System.Windows.Forms.Button();
            this.Pink = new System.Windows.Forms.CheckBox();
            this.Green = new System.Windows.Forms.CheckBox();
            this.Red = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // P1Button
            // 
            this.P1Button.BackColor = System.Drawing.Color.Black;
            this.P1Button.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.P1Button.ForeColor = System.Drawing.SystemColors.Window;
            this.P1Button.Location = new System.Drawing.Point(11, 11);
            this.P1Button.Margin = new System.Windows.Forms.Padding(2);
            this.P1Button.Name = "P1Button";
            this.P1Button.Size = new System.Drawing.Size(98, 41);
            this.P1Button.TabIndex = 25;
            this.P1Button.Text = "P1";
            this.P1Button.UseVisualStyleBackColor = false;
            this.P1Button.Click += new System.EventHandler(this.P1Button_Click);
            // 
            // P2Button
            // 
            this.P2Button.BackColor = System.Drawing.Color.Black;
            this.P2Button.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.P2Button.ForeColor = System.Drawing.SystemColors.Window;
            this.P2Button.Location = new System.Drawing.Point(11, 56);
            this.P2Button.Margin = new System.Windows.Forms.Padding(2);
            this.P2Button.Name = "P2Button";
            this.P2Button.Size = new System.Drawing.Size(98, 41);
            this.P2Button.TabIndex = 26;
            this.P2Button.Text = "P2";
            this.P2Button.UseVisualStyleBackColor = false;
            this.P2Button.Click += new System.EventHandler(this.P2Button_Click);
            // 
            // P3Button
            // 
            this.P3Button.BackColor = System.Drawing.Color.Black;
            this.P3Button.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.P3Button.ForeColor = System.Drawing.SystemColors.Window;
            this.P3Button.Location = new System.Drawing.Point(11, 101);
            this.P3Button.Margin = new System.Windows.Forms.Padding(2);
            this.P3Button.Name = "P3Button";
            this.P3Button.Size = new System.Drawing.Size(98, 41);
            this.P3Button.TabIndex = 27;
            this.P3Button.Text = "P3";
            this.P3Button.UseVisualStyleBackColor = false;
            this.P3Button.Click += new System.EventHandler(this.P3Button_Click);
            // 
            // proceedButton
            // 
            this.proceedButton.BackColor = System.Drawing.Color.Black;
            this.proceedButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.proceedButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.proceedButton.ForeColor = System.Drawing.SystemColors.Window;
            this.proceedButton.Location = new System.Drawing.Point(11, 342);
            this.proceedButton.Margin = new System.Windows.Forms.Padding(2);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(98, 41);
            this.proceedButton.TabIndex = 28;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = false;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // Pink
            // 
            this.Pink.AutoSize = true;
            this.Pink.BackColor = System.Drawing.Color.Transparent;
            this.Pink.ForeColor = System.Drawing.Color.Fuchsia;
            this.Pink.Location = new System.Drawing.Point(16, 201);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(47, 17);
            this.Pink.TabIndex = 31;
            this.Pink.Text = "Pink";
            this.Pink.UseVisualStyleBackColor = false;
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.BackColor = System.Drawing.Color.Transparent;
            this.Green.ForeColor = System.Drawing.Color.Lime;
            this.Green.Location = new System.Drawing.Point(16, 178);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(55, 17);
            this.Green.TabIndex = 30;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = false;
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.BackColor = System.Drawing.Color.Transparent;
            this.Red.ForeColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(16, 155);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(46, 17);
            this.Red.TabIndex = 29;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = false;
            // 
            // AddTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(572, 394);
            this.Controls.Add(this.Pink);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.P3Button);
            this.Controls.Add(this.P2Button);
            this.Controls.Add(this.P1Button);
            this.Name = "AddTriangle";
            this.Text = "AddTriangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button P1Button;
        private System.Windows.Forms.Button P2Button;
        private System.Windows.Forms.Button P3Button;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.CheckBox Pink;
        private System.Windows.Forms.CheckBox Green;
        private System.Windows.Forms.CheckBox Red;
    }
}