namespace GUI
{
    partial class triangleArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(triangleArea));
            this.comboBoxNewTrianglesList = new System.Windows.Forms.ComboBox();
            this.addNewTriangleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxNewTrianglesList
            // 
            this.comboBoxNewTrianglesList.BackColor = System.Drawing.Color.Black;
            this.comboBoxNewTrianglesList.ForeColor = System.Drawing.Color.Lime;
            this.comboBoxNewTrianglesList.FormattingEnabled = true;
            this.comboBoxNewTrianglesList.Location = new System.Drawing.Point(15, 25);
            this.comboBoxNewTrianglesList.Name = "comboBoxNewTrianglesList";
            this.comboBoxNewTrianglesList.Size = new System.Drawing.Size(182, 21);
            this.comboBoxNewTrianglesList.TabIndex = 28;
            this.comboBoxNewTrianglesList.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewTrianglesList_SelectedIndexChanged);
            // 
            // addNewTriangleLinkLabel
            // 
            this.addNewTriangleLinkLabel.AutoSize = true;
            this.addNewTriangleLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.addNewTriangleLinkLabel.LinkColor = System.Drawing.Color.Lime;
            this.addNewTriangleLinkLabel.Location = new System.Drawing.Point(12, 9);
            this.addNewTriangleLinkLabel.Name = "addNewTriangleLinkLabel";
            this.addNewTriangleLinkLabel.Size = new System.Drawing.Size(86, 13);
            this.addNewTriangleLinkLabel.TabIndex = 27;
            this.addNewTriangleLinkLabel.TabStop = true;
            this.addNewTriangleLinkLabel.Text = "Add new triangle";
            this.addNewTriangleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewTriangleLinkLabel_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(15, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 29;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.BackColor = System.Drawing.SystemColors.Desktop;
            this.Area.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Area.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Area.Location = new System.Drawing.Point(212, 27);
            this.Area.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(50, 19);
            this.Area.TabIndex = 35;
            this.Area.Text = "Area:";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxArea.Location = new System.Drawing.Point(266, 24);
            this.textBoxArea.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(195, 26);
            this.textBoxArea.TabIndex = 34;
            // 
            // triangleArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 705);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxNewTrianglesList);
            this.Controls.Add(this.addNewTriangleLinkLabel);
            this.Name = "triangleArea";
            this.Text = "triangleArea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNewTrianglesList;
        private System.Windows.Forms.LinkLabel addNewTriangleLinkLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.TextBox textBoxArea;
    }
}