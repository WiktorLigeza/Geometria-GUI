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
            this.graph = new System.Windows.Forms.Panel();
            this.labelAxis = new System.Windows.Forms.Label();
            this.labelNearest = new System.Windows.Forms.Label();
            this.labelPoint = new System.Windows.Forms.Label();
            this.labelVector = new System.Windows.Forms.Label();
            this.menuKDTButton = new System.Windows.Forms.Button();
            this.SIDE = new System.Windows.Forms.Button();
            this.zad2 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.zad3 = new System.Windows.Forms.Button();
            this.zad4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // menuKDTButton
            // 
            this.menuKDTButton.BackColor = System.Drawing.Color.Black;
            this.menuKDTButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuKDTButton.BackgroundImage")));
            this.menuKDTButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuKDTButton.ForeColor = System.Drawing.SystemColors.Window;
            this.menuKDTButton.Location = new System.Drawing.Point(603, 7);
            this.menuKDTButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuKDTButton.Name = "menuKDTButton";
            this.menuKDTButton.Size = new System.Drawing.Size(149, 60);
            this.menuKDTButton.TabIndex = 11;
            this.menuKDTButton.Text = "THE NEAREST";
            this.menuKDTButton.UseVisualStyleBackColor = false;
            this.menuKDTButton.Click += new System.EventHandler(this.menuKDTButton_Click);
            // 
            // SIDE
            // 
            this.SIDE.BackColor = System.Drawing.Color.Black;
            this.SIDE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SIDE.BackgroundImage")));
            this.SIDE.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SIDE.ForeColor = System.Drawing.SystemColors.Window;
            this.SIDE.Location = new System.Drawing.Point(603, 87);
            this.SIDE.Margin = new System.Windows.Forms.Padding(2);
            this.SIDE.Name = "SIDE";
            this.SIDE.Size = new System.Drawing.Size(149, 60);
            this.SIDE.TabIndex = 12;
            this.SIDE.Text = "ZAD 1";
            this.SIDE.UseVisualStyleBackColor = false;
            this.SIDE.Click += new System.EventHandler(this.SIDE_Click);
            // 
            // zad2
            // 
            this.zad2.BackColor = System.Drawing.Color.Black;
            this.zad2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zad2.BackgroundImage")));
            this.zad2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zad2.ForeColor = System.Drawing.SystemColors.Window;
            this.zad2.Location = new System.Drawing.Point(603, 168);
            this.zad2.Margin = new System.Windows.Forms.Padding(2);
            this.zad2.Name = "zad2";
            this.zad2.Size = new System.Drawing.Size(149, 60);
            this.zad2.TabIndex = 13;
            this.zad2.Text = "ZAD 2";
            this.zad2.UseVisualStyleBackColor = false;
            this.zad2.Click += new System.EventHandler(this.zad2_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Black;
            this.refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh.BackgroundImage")));
            this.refresh.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refresh.ForeColor = System.Drawing.SystemColors.Window;
            this.refresh.Location = new System.Drawing.Point(298, 41);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(149, 60);
            this.refresh.TabIndex = 14;
            this.refresh.Text = "REFRESH";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // zad3
            // 
            this.zad3.BackColor = System.Drawing.Color.Black;
            this.zad3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zad3.BackgroundImage")));
            this.zad3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zad3.ForeColor = System.Drawing.SystemColors.Window;
            this.zad3.Location = new System.Drawing.Point(603, 250);
            this.zad3.Margin = new System.Windows.Forms.Padding(2);
            this.zad3.Name = "zad3";
            this.zad3.Size = new System.Drawing.Size(149, 60);
            this.zad3.TabIndex = 15;
            this.zad3.Text = "ZAD 3";
            this.zad3.UseVisualStyleBackColor = false;
            this.zad3.Click += new System.EventHandler(this.zad3_Click);
            // 
            // zad4
            // 
            this.zad4.BackColor = System.Drawing.Color.Black;
            this.zad4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zad4.BackgroundImage")));
            this.zad4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zad4.ForeColor = System.Drawing.SystemColors.Window;
            this.zad4.Location = new System.Drawing.Point(603, 329);
            this.zad4.Margin = new System.Windows.Forms.Padding(2);
            this.zad4.Name = "zad4";
            this.zad4.Size = new System.Drawing.Size(149, 60);
            this.zad4.TabIndex = 16;
            this.zad4.Text = "ZAD 4";
            this.zad4.UseVisualStyleBackColor = false;
            this.zad4.Click += new System.EventHandler(this.zad4_Click);
            // 
            // POINTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(983, 466);
            this.Controls.Add(this.zad4);
            this.Controls.Add(this.zad3);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.zad2);
            this.Controls.Add(this.SIDE);
            this.Controls.Add(this.menuKDTButton);
            this.Controls.Add(this.labelVector);
            this.Controls.Add(this.labelNearest);
            this.Controls.Add(this.labelAxis);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.graph);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "POINTS";
            this.Text = "POINTS";
            this.Load += new System.EventHandler(this.POINTS_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.POINTS_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel graph;
        private System.Windows.Forms.Label labelAxis;
        private System.Windows.Forms.Label labelNearest;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Label labelVector;
        private System.Windows.Forms.Button menuKDTButton;
        private System.Windows.Forms.Button SIDE;
        private System.Windows.Forms.Button zad2;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button zad3;
        private System.Windows.Forms.Button zad4;
    }
}