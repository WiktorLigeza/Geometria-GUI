namespace GUI
{
    partial class Line
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Line));
            this.button1 = new System.Windows.Forms.Button();
            this.addNewPointLinkLabel = new System.Windows.Forms.LinkLabel();
            this.comboBoxNewPointsList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSLE = new System.Windows.Forms.TextBox();
            this.addNewLineLinkLabel = new System.Windows.Forms.LinkLabel();
            this.comboBoxNewLinesList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(11, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 25;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addNewPointLinkLabel
            // 
            this.addNewPointLinkLabel.AutoSize = true;
            this.addNewPointLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.addNewPointLinkLabel.LinkColor = System.Drawing.Color.Lime;
            this.addNewPointLinkLabel.Location = new System.Drawing.Point(8, 58);
            this.addNewPointLinkLabel.Name = "addNewPointLinkLabel";
            this.addNewPointLinkLabel.Size = new System.Drawing.Size(75, 13);
            this.addNewPointLinkLabel.TabIndex = 27;
            this.addNewPointLinkLabel.TabStop = true;
            this.addNewPointLinkLabel.Text = "Add new point";
            this.addNewPointLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewPointLinkLabel_LinkClicked);
            // 
            // comboBoxNewPointsList
            // 
            this.comboBoxNewPointsList.BackColor = System.Drawing.Color.Black;
            this.comboBoxNewPointsList.ForeColor = System.Drawing.Color.Lime;
            this.comboBoxNewPointsList.FormattingEnabled = true;
            this.comboBoxNewPointsList.Location = new System.Drawing.Point(8, 74);
            this.comboBoxNewPointsList.Name = "comboBoxNewPointsList";
            this.comboBoxNewPointsList.Size = new System.Drawing.Size(129, 21);
            this.comboBoxNewPointsList.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(414, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "SLE:";
            // 
            // textBoxSLE
            // 
            this.textBoxSLE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSLE.Location = new System.Drawing.Point(465, 22);
            this.textBoxSLE.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSLE.Name = "textBoxSLE";
            this.textBoxSLE.Size = new System.Drawing.Size(157, 26);
            this.textBoxSLE.TabIndex = 36;
            // 
            // addNewLineLinkLabel
            // 
            this.addNewLineLinkLabel.AutoSize = true;
            this.addNewLineLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.addNewLineLinkLabel.LinkColor = System.Drawing.Color.Lime;
            this.addNewLineLinkLabel.Location = new System.Drawing.Point(8, 9);
            this.addNewLineLinkLabel.Name = "addNewLineLinkLabel";
            this.addNewLineLinkLabel.Size = new System.Drawing.Size(68, 13);
            this.addNewLineLinkLabel.TabIndex = 35;
            this.addNewLineLinkLabel.TabStop = true;
            this.addNewLineLinkLabel.Text = "Add new line";
            this.addNewLineLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewLineLinkLabel_LinkClicked);
            // 
            // comboBoxNewLinesList
            // 
            this.comboBoxNewLinesList.BackColor = System.Drawing.Color.Black;
            this.comboBoxNewLinesList.ForeColor = System.Drawing.Color.Lime;
            this.comboBoxNewLinesList.FormattingEnabled = true;
            this.comboBoxNewLinesList.Location = new System.Drawing.Point(8, 25);
            this.comboBoxNewLinesList.Name = "comboBoxNewLinesList";
            this.comboBoxNewLinesList.Size = new System.Drawing.Size(401, 21);
            this.comboBoxNewLinesList.TabIndex = 34;
            this.comboBoxNewLinesList.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewLinesList_SelectedIndexChanged_1);
            // 
            // Line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(648, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSLE);
            this.Controls.Add(this.addNewLineLinkLabel);
            this.Controls.Add(this.comboBoxNewLinesList);
            this.Controls.Add(this.addNewPointLinkLabel);
            this.Controls.Add(this.comboBoxNewPointsList);
            this.Controls.Add(this.button1);
            this.Name = "Line";
            this.Text = "Line";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel addNewPointLinkLabel;
        private System.Windows.Forms.ComboBox comboBoxNewPointsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSLE;
        private System.Windows.Forms.LinkLabel addNewLineLinkLabel;
        private System.Windows.Forms.ComboBox comboBoxNewLinesList;
    }
}