namespace GUI
{
    partial class POINTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POINTS));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxElements = new System.Windows.Forms.GroupBox();
            this.labelNoE = new System.Windows.Forms.Label();
            this.textBoxElemetns = new System.Windows.Forms.TextBox();
            this.graph = new System.Windows.Forms.Panel();
            this.labelAxis = new System.Windows.Forms.Label();
            this.labelNearest = new System.Windows.Forms.Label();
            this.labelPoint = new System.Windows.Forms.Label();
            this.labelVector = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(299, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxY.Location = new System.Drawing.Point(88, 32);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(32, 26);
            this.textBoxY.TabIndex = 2;
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
            this.labelX.Click += new System.EventHandler(this.labelX_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Controls.Add(this.labelY);
            this.groupBox1.Controls.Add(this.textBoxX);
            this.groupBox1.Controls.Add(this.labelX);
            this.groupBox1.Controls.Add(this.textBoxY);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(147, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(140, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinates";
            // 
            // groupBoxElements
            // 
            this.groupBoxElements.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBoxElements.Controls.Add(this.labelNoE);
            this.groupBoxElements.Controls.Add(this.textBoxElemetns);
            this.groupBoxElements.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxElements.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxElements.Location = new System.Drawing.Point(291, 11);
            this.groupBoxElements.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxElements.Name = "groupBoxElements";
            this.groupBoxElements.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxElements.Size = new System.Drawing.Size(289, 72);
            this.groupBoxElements.TabIndex = 6;
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
            // graph
            // 
            this.graph.BackColor = System.Drawing.SystemColors.Window;
            this.graph.ForeColor = System.Drawing.Color.Black;
            this.graph.Location = new System.Drawing.Point(147, 105);
            this.graph.Margin = new System.Windows.Forms.Padding(2);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(433, 269);
            this.graph.TabIndex = 7;
            this.graph.Paint += new System.Windows.Forms.PaintEventHandler(this.graph_Paint);
            this.graph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graph_MouseMove);
            this.graph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graph_MouseUp);
            // 
            // labelAxis
            // 
            this.labelAxis.AutoSize = true;
            this.labelAxis.BackColor = System.Drawing.Color.Transparent;
            this.labelAxis.ForeColor = System.Drawing.Color.White;
            this.labelAxis.Location = new System.Drawing.Point(144, 376);
            this.labelAxis.Name = "labelAxis";
            this.labelAxis.Size = new System.Drawing.Size(25, 13);
            this.labelAxis.TabIndex = 5;
            this.labelAxis.Text = "axis";
            // 
            // labelNearest
            // 
            this.labelNearest.AutoSize = true;
            this.labelNearest.BackColor = System.Drawing.Color.Transparent;
            this.labelNearest.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelNearest.Location = new System.Drawing.Point(393, 376);
            this.labelNearest.Name = "labelNearest";
            this.labelNearest.Size = new System.Drawing.Size(42, 13);
            this.labelNearest.TabIndex = 8;
            this.labelNearest.Text = "nearest";
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.BackColor = System.Drawing.Color.Transparent;
            this.labelPoint.ForeColor = System.Drawing.Color.Red;
            this.labelPoint.Location = new System.Drawing.Point(278, 376);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(30, 13);
            this.labelPoint.TabIndex = 9;
            this.labelPoint.Text = "point";
            // 
            // labelVector
            // 
            this.labelVector.AutoSize = true;
            this.labelVector.BackColor = System.Drawing.Color.Transparent;
            this.labelVector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelVector.Location = new System.Drawing.Point(497, 376);
            this.labelVector.Name = "labelVector";
            this.labelVector.Size = new System.Drawing.Size(37, 13);
            this.labelVector.TabIndex = 10;
            this.labelVector.Text = "vector";
            // 
            // POINTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(730, 466);
            this.Controls.Add(this.labelVector);
            this.Controls.Add(this.labelNearest);
            this.Controls.Add(this.labelAxis);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.groupBoxElements);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "POINTS";
            this.Text = "POINTS";
            this.Load += new System.EventHandler(this.POINTS_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.POINTS_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxElements.ResumeLayout(false);
            this.groupBoxElements.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxElements;
        private System.Windows.Forms.Label labelNoE;
        private System.Windows.Forms.TextBox textBoxElemetns;
        private System.Windows.Forms.Panel graph;
        private System.Windows.Forms.Label labelAxis;
        private System.Windows.Forms.Label labelNearest;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Label labelVector;
    }
}