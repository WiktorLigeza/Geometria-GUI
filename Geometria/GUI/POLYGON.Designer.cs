namespace GUI
{
    partial class POLYGON
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POLYGON));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxVertices = new System.Windows.Forms.TextBox();
            this.labelNoE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(341, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxVertices
            // 
            this.textBoxVertices.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVertices.Location = new System.Drawing.Point(263, 37);
            this.textBoxVertices.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVertices.Name = "textBoxVertices";
            this.textBoxVertices.Size = new System.Drawing.Size(74, 26);
            this.textBoxVertices.TabIndex = 26;
            // 
            // labelNoE
            // 
            this.labelNoE.AutoSize = true;
            this.labelNoE.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelNoE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNoE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNoE.Location = new System.Drawing.Point(29, 40);
            this.labelNoE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoE.Name = "labelNoE";
            this.labelNoE.Size = new System.Drawing.Size(230, 19);
            this.labelNoE.TabIndex = 27;
            this.labelNoE.Text = "Enter the number of vertices:";
            // 
            // POLYGON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 95);
            this.Controls.Add(this.labelNoE);
            this.Controls.Add(this.textBoxVertices);
            this.Controls.Add(this.button1);
            this.Name = "POLYGON";
            this.Text = "POLYGON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxVertices;
        private System.Windows.Forms.Label labelNoE;
    }
}