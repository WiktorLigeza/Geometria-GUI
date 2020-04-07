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
            this.addPointButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonII = new System.Windows.Forms.Button();
            this.buttonIII = new System.Windows.Forms.Button();
            this.buttonIV = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.button3a = new System.Windows.Forms.Button();
            this.button3b = new System.Windows.Forms.Button();
            this.addTraingleButton = new System.Windows.Forms.Button();
            this.addPolygonButton = new System.Windows.Forms.Button();
            this.buttonVI = new System.Windows.Forms.Button();
            this.buttonVII = new System.Windows.Forms.Button();
            this.addCircleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.BackColor = System.Drawing.SystemColors.Window;
            this.graph.ForeColor = System.Drawing.Color.Black;
            this.graph.Location = new System.Drawing.Point(263, 116);
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
            this.labelAxis.Location = new System.Drawing.Point(260, 387);
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
            this.labelNearest.Location = new System.Drawing.Point(509, 387);
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
            this.labelPoint.Location = new System.Drawing.Point(394, 387);
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
            this.labelVector.Location = new System.Drawing.Point(613, 387);
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
            this.menuKDTButton.Location = new System.Drawing.Point(719, 18);
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
            this.SIDE.Location = new System.Drawing.Point(719, 98);
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
            this.zad2.Location = new System.Drawing.Point(719, 179);
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
            this.refresh.Location = new System.Drawing.Point(416, 52);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(127, 60);
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
            this.zad3.Location = new System.Drawing.Point(719, 261);
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
            this.zad4.Location = new System.Drawing.Point(719, 340);
            this.zad4.Margin = new System.Windows.Forms.Padding(2);
            this.zad4.Name = "zad4";
            this.zad4.Size = new System.Drawing.Size(149, 60);
            this.zad4.TabIndex = 16;
            this.zad4.Text = "ZAD 4";
            this.zad4.UseVisualStyleBackColor = false;
            this.zad4.Click += new System.EventHandler(this.zad4_Click);
            // 
            // addPointButton
            // 
            this.addPointButton.BackColor = System.Drawing.Color.Black;
            this.addPointButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addPointButton.BackgroundImage")));
            this.addPointButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addPointButton.ForeColor = System.Drawing.SystemColors.Window;
            this.addPointButton.Location = new System.Drawing.Point(263, 52);
            this.addPointButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPointButton.Name = "addPointButton";
            this.addPointButton.Size = new System.Drawing.Size(149, 60);
            this.addPointButton.TabIndex = 17;
            this.addPointButton.Text = "ADD POINT";
            this.addPointButton.UseVisualStyleBackColor = false;
            this.addPointButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(547, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 60);
            this.button2.TabIndex = 18;
            this.button2.Text = "ADD LINE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonI
            // 
            this.buttonI.BackColor = System.Drawing.Color.Black;
            this.buttonI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonI.BackgroundImage")));
            this.buttonI.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonI.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonI.Location = new System.Drawing.Point(88, 18);
            this.buttonI.Margin = new System.Windows.Forms.Padding(2);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(149, 60);
            this.buttonI.TabIndex = 19;
            this.buttonI.Text = "i";
            this.buttonI.UseVisualStyleBackColor = false;
            this.buttonI.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // buttonII
            // 
            this.buttonII.BackColor = System.Drawing.Color.Black;
            this.buttonII.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonII.BackgroundImage")));
            this.buttonII.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonII.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonII.Location = new System.Drawing.Point(88, 98);
            this.buttonII.Margin = new System.Windows.Forms.Padding(2);
            this.buttonII.Name = "buttonII";
            this.buttonII.Size = new System.Drawing.Size(149, 60);
            this.buttonII.TabIndex = 20;
            this.buttonII.Text = "ii";
            this.buttonII.UseVisualStyleBackColor = false;
            this.buttonII.Click += new System.EventHandler(this.buttonII_Click);
            // 
            // buttonIII
            // 
            this.buttonIII.BackColor = System.Drawing.Color.Black;
            this.buttonIII.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIII.BackgroundImage")));
            this.buttonIII.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIII.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonIII.Location = new System.Drawing.Point(88, 179);
            this.buttonIII.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIII.Name = "buttonIII";
            this.buttonIII.Size = new System.Drawing.Size(149, 60);
            this.buttonIII.TabIndex = 21;
            this.buttonIII.Text = "iii";
            this.buttonIII.UseVisualStyleBackColor = false;
            this.buttonIII.Click += new System.EventHandler(this.buttonIII_Click);
            // 
            // buttonIV
            // 
            this.buttonIV.BackColor = System.Drawing.Color.Black;
            this.buttonIV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIV.BackgroundImage")));
            this.buttonIV.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIV.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonIV.Location = new System.Drawing.Point(88, 261);
            this.buttonIV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIV.Name = "buttonIV";
            this.buttonIV.Size = new System.Drawing.Size(149, 60);
            this.buttonIV.TabIndex = 22;
            this.buttonIV.Text = "iv";
            this.buttonIV.UseVisualStyleBackColor = false;
            this.buttonIV.Click += new System.EventHandler(this.buttonIV_Click);
            // 
            // buttonV
            // 
            this.buttonV.BackColor = System.Drawing.Color.Black;
            this.buttonV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonV.BackgroundImage")));
            this.buttonV.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonV.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonV.Location = new System.Drawing.Point(88, 340);
            this.buttonV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(149, 60);
            this.buttonV.TabIndex = 23;
            this.buttonV.Text = "v";
            this.buttonV.UseVisualStyleBackColor = false;
            this.buttonV.Click += new System.EventHandler(this.buttonV_Click);
            // 
            // button3a
            // 
            this.button3a.BackColor = System.Drawing.Color.Black;
            this.button3a.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3a.BackgroundImage")));
            this.button3a.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3a.ForeColor = System.Drawing.SystemColors.Window;
            this.button3a.Location = new System.Drawing.Point(719, 422);
            this.button3a.Margin = new System.Windows.Forms.Padding(2);
            this.button3a.Name = "button3a";
            this.button3a.Size = new System.Drawing.Size(149, 60);
            this.button3a.TabIndex = 24;
            this.button3a.Text = "3 a";
            this.button3a.UseVisualStyleBackColor = false;
            this.button3a.Click += new System.EventHandler(this.button3a_Click);
            // 
            // button3b
            // 
            this.button3b.BackColor = System.Drawing.Color.Black;
            this.button3b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3b.BackgroundImage")));
            this.button3b.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3b.ForeColor = System.Drawing.SystemColors.Window;
            this.button3b.Location = new System.Drawing.Point(719, 505);
            this.button3b.Margin = new System.Windows.Forms.Padding(2);
            this.button3b.Name = "button3b";
            this.button3b.Size = new System.Drawing.Size(149, 60);
            this.button3b.TabIndex = 25;
            this.button3b.Text = "3 b";
            this.button3b.UseVisualStyleBackColor = false;
            this.button3b.Click += new System.EventHandler(this.button3b_Click);
            // 
            // addTraingleButton
            // 
            this.addTraingleButton.BackColor = System.Drawing.Color.Black;
            this.addTraingleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTraingleButton.BackgroundImage")));
            this.addTraingleButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTraingleButton.ForeColor = System.Drawing.SystemColors.Window;
            this.addTraingleButton.Location = new System.Drawing.Point(263, 402);
            this.addTraingleButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTraingleButton.Name = "addTraingleButton";
            this.addTraingleButton.Size = new System.Drawing.Size(149, 60);
            this.addTraingleButton.TabIndex = 26;
            this.addTraingleButton.Text = "ADD TRIANGLE";
            this.addTraingleButton.UseVisualStyleBackColor = false;
            this.addTraingleButton.Click += new System.EventHandler(this.addTraingleButton_Click);
            // 
            // addPolygonButton
            // 
            this.addPolygonButton.BackColor = System.Drawing.Color.Black;
            this.addPolygonButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addPolygonButton.BackgroundImage")));
            this.addPolygonButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addPolygonButton.ForeColor = System.Drawing.SystemColors.Window;
            this.addPolygonButton.Location = new System.Drawing.Point(547, 402);
            this.addPolygonButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPolygonButton.Name = "addPolygonButton";
            this.addPolygonButton.Size = new System.Drawing.Size(149, 60);
            this.addPolygonButton.TabIndex = 27;
            this.addPolygonButton.Text = "ADD POLYGON";
            this.addPolygonButton.UseVisualStyleBackColor = false;
            this.addPolygonButton.Click += new System.EventHandler(this.addPolygonButton_Click);
            // 
            // buttonVI
            // 
            this.buttonVI.BackColor = System.Drawing.Color.Black;
            this.buttonVI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVI.BackgroundImage")));
            this.buttonVI.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVI.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonVI.Location = new System.Drawing.Point(88, 422);
            this.buttonVI.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVI.Name = "buttonVI";
            this.buttonVI.Size = new System.Drawing.Size(149, 60);
            this.buttonVI.TabIndex = 28;
            this.buttonVI.Text = "vi";
            this.buttonVI.UseVisualStyleBackColor = false;
            this.buttonVI.Click += new System.EventHandler(this.buttonVI_Click);
            // 
            // buttonVII
            // 
            this.buttonVII.BackColor = System.Drawing.Color.Black;
            this.buttonVII.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVII.BackgroundImage")));
            this.buttonVII.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVII.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonVII.Location = new System.Drawing.Point(88, 505);
            this.buttonVII.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVII.Name = "buttonVII";
            this.buttonVII.Size = new System.Drawing.Size(149, 60);
            this.buttonVII.TabIndex = 29;
            this.buttonVII.Text = "vii";
            this.buttonVII.UseVisualStyleBackColor = false;
            this.buttonVII.Click += new System.EventHandler(this.buttonVII_Click);
            // 
            // addCircleButton
            // 
            this.addCircleButton.BackColor = System.Drawing.Color.Black;
            this.addCircleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCircleButton.BackgroundImage")));
            this.addCircleButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addCircleButton.ForeColor = System.Drawing.SystemColors.Window;
            this.addCircleButton.Location = new System.Drawing.Point(416, 402);
            this.addCircleButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCircleButton.Name = "addCircleButton";
            this.addCircleButton.Size = new System.Drawing.Size(127, 60);
            this.addCircleButton.TabIndex = 30;
            this.addCircleButton.Text = "ADD CIRCLE";
            this.addCircleButton.UseVisualStyleBackColor = false;
            this.addCircleButton.Click += new System.EventHandler(this.addCircleButton_Click);
            // 
            // POINTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 598);
            this.Controls.Add(this.addCircleButton);
            this.Controls.Add(this.buttonVII);
            this.Controls.Add(this.buttonVI);
            this.Controls.Add(this.addPolygonButton);
            this.Controls.Add(this.addTraingleButton);
            this.Controls.Add(this.button3b);
            this.Controls.Add(this.button3a);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonIV);
            this.Controls.Add(this.buttonIII);
            this.Controls.Add(this.buttonII);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addPointButton);
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
        private System.Windows.Forms.Button addPointButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonII;
        private System.Windows.Forms.Button buttonIII;
        private System.Windows.Forms.Button buttonIV;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button button3a;
        private System.Windows.Forms.Button button3b;
        private System.Windows.Forms.Button addTraingleButton;
        private System.Windows.Forms.Button addPolygonButton;
        private System.Windows.Forms.Button buttonVI;
        private System.Windows.Forms.Button buttonVII;
        private System.Windows.Forms.Button addCircleButton;
    }
}