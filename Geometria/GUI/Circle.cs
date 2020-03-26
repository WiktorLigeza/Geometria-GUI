using Geometria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Circle : Form
    {
        public PointModel point = new PointModel();
        PointModel P1 = new PointModel();
        PointModel P2 = new PointModel();
        public LineModel line = new LineModel();
        public double r;

        int x = 0, y = 0, p1x = 0, p1y = 0, p2x = 0, p2y = 0;
        public Circle()
        {
            InitializeComponent();
        }











        ////////////////////////////////BUTTONS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void button1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                point.x = x;
                point.y = y;
                P1.x = p1x;
                P1.y = p1y;
                P2.x = p2x;
                P2.y = p2y;
                line.A = P1;
                line.B = P2;
                this.Close();
            }

            else
            {
                MessageBox.Show("Invalid data set, please try again ;)");


                // refresh form
                //textBoxX.Text = null;
                //textBoxY.Text = null;
                //P1X.Text = null;
                //P1Y.Text = null;
                //P2X.Text = null;
                //P2Y.Text = null;

            }
        }

        private void RandPoint_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            point.x = random.Next(-20, 20);
            point.y = random.Next(-20, 20);
            r = random.Next(0,60);
            textBoxX.Text = point.x.ToString();
            textBoxY.Text = point.y.ToString();
            textBoxRadious.Text = r.ToString();
        }

        private void RandLine_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            P1.x = random.Next(-100, 100);
            P1.y = random.Next(-100, 100);
            P2.x = random.Next(-100, 100);
            P2.y = random.Next(-100, 100);
            line.A = P1;
            line.B = P2;

            P1X.Text = P1.x.ToString();
            P1Y.Text = P1.y.ToString();
            P2X.Text = P2.x.ToString();
            P2Y.Text = P2.y.ToString();
        }

        bool validate()
        {
            bool output = true;


            if (!int.TryParse(textBoxX.Text, out x))
            {
                output = false;
            }
            if (!int.TryParse(textBoxY.Text, out y))
            {
                output = false;
            }
            if (!int.TryParse(P1X.Text, out p1x))
            {
                output = false;
            }
            if (!int.TryParse(P1Y.Text, out p1y))
            {
                output = false;
            }
            if (!int.TryParse(P2X.Text, out p2x))
            {
                output = false;
            }
            if (!int.TryParse(P2Y.Text, out p2y))
            {
                output = false;
            }
            if (!double.TryParse(textBoxRadious.Text, out r))
            {
                output = false;
            }
            return output;
        }
    }
}
