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
    public partial class SIDE : Form
    {
        public PointModel point = new PointModel();
        public PointModel P1 = new PointModel();
        public PointModel P2 = new PointModel();
        public LineModel line = new LineModel();


        int x = 0, y = 0, p1x = 0, p1y = 0, p2x = 0, p2y =0;

      

        public SIDE()
        {
            InitializeComponent();
        }

       

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
                textBoxX.Text = null;
                textBoxY.Text = null;
                P1X = null;
                P1Y = null;
                P2X = null;
                P2Y = null;

            }
        }

        private void Randomize_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            point.x = random.Next(-150, 150);
            point.y = random.Next(-120, 120);
            P1.x = random.Next(-150, 150);
            P1.y = random.Next(-120, 120);
            P2.x = random.Next(-150, 150);
            P2.y = random.Next(-120, 120);
            line.A = P1;
            line.B = P2;
            this.Close();
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
            return output;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
