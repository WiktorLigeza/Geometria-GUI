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
    public partial class AddLine : Form
    {
        //return
        public string color;
        public LineModel line;
        public double[] SLE = new double[2];

        double A = 0, B = 0, p1x = 0, p1y = 0, p2x = 0, p2y = 0;
        public AddLine()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Red.Checked)
            {
                color = "red";
            }
            else if (Green.Checked)
            {
                color = "green";
            }
            else if (Pink.Checked)
            {
                color = "pink";
            }
            else color = "";

            if (usingCoordinates.Checked && validatePoints())
            {
                PointModel P1 = new PointModel();
                PointModel P2 = new PointModel();
                line = new LineModel();
                P1.x = p1x;
                P1.y = p1y;
                P2.x = p2x;
                P2.y = p2y;
                line.A = P1;
                line.B = P2;
            }
            else if (usingSLE.Checked && validateSLE())
            {
                
                SLE[0] = A;
                SLE[1] = B;
            }
            else
            {
                MessageBox.Show("Invalid data set");
                this.DialogResult = DialogResult.None;
            }
        }

        bool validatePoints()
        {
            bool output = true;

            if (!double.TryParse(P1X.Text, out p1x))
            {
                output = false;
            }
            if (!double.TryParse(P1Y.Text, out p1y))
            {
                output = false;
            }
            if (!double.TryParse(P2X.Text, out p2x))
            {
                output = false;
            }
            if (!double.TryParse(P2Y.Text, out p2y))
            {
                output = false;
            }

            return output;
        }

        bool validateSLE()
        {
            bool output = true;

            if (!double.TryParse(textBoxA.Text, out A))
            {
                output = false;
            }
            if (!double.TryParse(textBoxB.Text, out B))
            {
                output = false;
            }


            return output;
        }
    }
}
