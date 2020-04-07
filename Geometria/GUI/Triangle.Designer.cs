namespace GUI
{
    partial class Triangle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Triangle));
            this.addNewPointLinkLabel = new System.Windows.Forms.LinkLabel();
            this.comboBoxNewPointsList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addNewTriangleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.comboBoxNewTrianglesList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addNewPointLinkLabel
            // 
            this.addNewPointLinkLabel.AutoSize = true;
            this.addNewPointLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.addNewPointLinkLabel.LinkColor = System.Drawing.Color.Lime;
            this.addNewPointLinkLabel.Location = new System.Drawing.Point(12, 6);
            this.addNewPointLinkLabel.Name = "addNewPointLinkLabel";
            this.addNewPointLinkLabel.Size = new System.Drawing.Size(75, 13);
            this.addNewPointLinkLabel.TabIndex = 23;
            this.addNewPointLinkLabel.TabStop = true;
            this.addNewPointLinkLabel.Text = "Add new point";
            this.addNewPointLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewPointLinkLabel_LinkClicked);
            // 
            // comboBoxNewPointsList
            // 
            this.comboBoxNewPointsList.BackColor = System.Drawing.Color.Black;
            this.comboBoxNewPointsList.ForeColor = System.Drawing.Color.Lime;
            this.comboBoxNewPointsList.FormattingEnabled = true;
            this.comboBoxNewPointsList.Location = new System.Drawing.Point(12, 22);
            this.comboBoxNewPointsList.Name = "comboBoxNewPointsList";
            this.comboBoxNewPointsList.Size = new System.Drawing.Size(129, 21);
            this.comboBoxNewPointsList.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(11, 546);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 24;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addNewTriangleLinkLabel
            // 
            this.addNewTriangleLinkLabel.AutoSize = true;
            this.addNewTriangleLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.addNewTriangleLinkLabel.LinkColor = System.Drawing.Color.Lime;
            this.addNewTriangleLinkLabel.Location = new System.Drawing.Point(8, 59);
            this.addNewTriangleLinkLabel.Name = "addNewTriangleLinkLabel";
            this.addNewTriangleLinkLabel.Size = new System.Drawing.Size(86, 13);
            this.addNewTriangleLinkLabel.TabIndex = 25;
            this.addNewTriangleLinkLabel.TabStop = true;
            this.addNewTriangleLinkLabel.Text = "Add new triangle";
            this.addNewTriangleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewTriangleLinkLabel_LinkClicked);
            // 
            // comboBoxNewTrianglesList
            // 
            this.comboBoxNewTrianglesList.BackColor = System.Drawing.Color.Black;
            this.comboBoxNewTrianglesList.ForeColor = System.Drawing.Color.Lime;
            this.comboBoxNewTrianglesList.FormattingEnabled = true;
            this.comboBoxNewTrianglesList.Location = new System.Drawing.Point(11, 75);
            this.comboBoxNewTrianglesList.Name = "comboBoxNewTrianglesList";
            this.comboBoxNewTrianglesList.Size = new System.Drawing.Size(182, 21);
            this.comboBoxNewTrianglesList.TabIndex = 26;
            // 
            // Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(586, 601);
            this.Controls.Add(this.comboBoxNewTrianglesList);
            this.Controls.Add(this.addNewTriangleLinkLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addNewPointLinkLabel);
            this.Controls.Add(this.comboBoxNewPointsList);
            this.Name = "Triangle";
            this.Text = "Triangle";
            this.Load += new System.EventHandler(this.Triangle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel addNewPointLinkLabel;
        private System.Windows.Forms.ComboBox comboBoxNewPointsList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel addNewTriangleLinkLabel;
        private System.Windows.Forms.ComboBox comboBoxNewTrianglesList;
    }
}