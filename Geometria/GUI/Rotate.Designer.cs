namespace GUI
{
    partial class Rotate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rotate));
            this.comboBoxNewLinesList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addNewLineLinkLabel = new System.Windows.Forms.LinkLabel();
            this.labelNoE = new System.Windows.Forms.Label();
            this.textBoxDegree = new System.Windows.Forms.TextBox();
            this.AinB = new System.Windows.Forms.CheckBox();
            this.BinA = new System.Windows.Forms.CheckBox();
            this.textBoxSLE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxNewLinesList
            // 
            this.comboBoxNewLinesList.BackColor = System.Drawing.Color.Black;
            this.comboBoxNewLinesList.ForeColor = System.Drawing.Color.Lime;
            this.comboBoxNewLinesList.FormattingEnabled = true;
            this.comboBoxNewLinesList.Location = new System.Drawing.Point(12, 22);
            this.comboBoxNewLinesList.Name = "comboBoxNewLinesList";
            this.comboBoxNewLinesList.Size = new System.Drawing.Size(401, 21);
            this.comboBoxNewLinesList.TabIndex = 0;
            this.comboBoxNewLinesList.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewLinesList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(11, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addNewLineLinkLabel
            // 
            this.addNewLineLinkLabel.AutoSize = true;
            this.addNewLineLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.addNewLineLinkLabel.LinkColor = System.Drawing.Color.Lime;
            this.addNewLineLinkLabel.Location = new System.Drawing.Point(12, 6);
            this.addNewLineLinkLabel.Name = "addNewLineLinkLabel";
            this.addNewLineLinkLabel.Size = new System.Drawing.Size(68, 13);
            this.addNewLineLinkLabel.TabIndex = 21;
            this.addNewLineLinkLabel.TabStop = true;
            this.addNewLineLinkLabel.Text = "Add new line";
            this.addNewLineLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewLineLinkLabel_LinkClicked);
            // 
            // labelNoE
            // 
            this.labelNoE.AutoSize = true;
            this.labelNoE.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelNoE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNoE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNoE.Location = new System.Drawing.Point(8, 57);
            this.labelNoE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoE.Name = "labelNoE";
            this.labelNoE.Size = new System.Drawing.Size(82, 19);
            this.labelNoE.TabIndex = 29;
            this.labelNoE.Text = "By angle:";
            // 
            // textBoxDegree
            // 
            this.textBoxDegree.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDegree.Location = new System.Drawing.Point(94, 54);
            this.textBoxDegree.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDegree.Name = "textBoxDegree";
            this.textBoxDegree.Size = new System.Drawing.Size(74, 26);
            this.textBoxDegree.TabIndex = 28;
            // 
            // AinB
            // 
            this.AinB.AutoSize = true;
            this.AinB.BackColor = System.Drawing.Color.Transparent;
            this.AinB.ForeColor = System.Drawing.Color.Fuchsia;
            this.AinB.Location = new System.Drawing.Point(188, 52);
            this.AinB.Name = "AinB";
            this.AinB.Size = new System.Drawing.Size(94, 17);
            this.AinB.TabIndex = 30;
            this.AinB.Text = "A in terms of B";
            this.AinB.UseVisualStyleBackColor = false;
            // 
            // BinA
            // 
            this.BinA.AutoSize = true;
            this.BinA.BackColor = System.Drawing.Color.Transparent;
            this.BinA.ForeColor = System.Drawing.Color.Fuchsia;
            this.BinA.Location = new System.Drawing.Point(188, 75);
            this.BinA.Name = "BinA";
            this.BinA.Size = new System.Drawing.Size(94, 17);
            this.BinA.TabIndex = 31;
            this.BinA.Text = "B in terms of A";
            this.BinA.UseVisualStyleBackColor = false;
            // 
            // textBoxSLE
            // 
            this.textBoxSLE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSLE.Location = new System.Drawing.Point(469, 19);
            this.textBoxSLE.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSLE.Name = "textBoxSLE";
            this.textBoxSLE.Size = new System.Drawing.Size(195, 26);
            this.textBoxSLE.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(418, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "SLE:";
            // 
            // Rotate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSLE);
            this.Controls.Add(this.BinA);
            this.Controls.Add(this.AinB);
            this.Controls.Add(this.labelNoE);
            this.Controls.Add(this.textBoxDegree);
            this.Controls.Add(this.addNewLineLinkLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxNewLinesList);
            this.Name = "Rotate";
            this.Text = "SelectLineFromNewLinesList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNewLinesList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel addNewLineLinkLabel;
        private System.Windows.Forms.Label labelNoE;
        private System.Windows.Forms.TextBox textBoxDegree;
        private System.Windows.Forms.CheckBox AinB;
        private System.Windows.Forms.CheckBox BinA;
        private System.Windows.Forms.TextBox textBoxSLE;
        private System.Windows.Forms.Label label1;
    }
}