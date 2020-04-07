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
    public partial class AddTriangle : Form
    {
        public TriangleModel triangle = new TriangleModel();
        AddPoint ap = new AddPoint();
        public string color;
        public AddTriangle()
        {
            InitializeComponent();
        }

        private void P1Button_Click(object sender, EventArgs e)
        {
            ap = new AddPoint();
            if (ap.ShowDialog() == DialogResult.OK)
            {
                triangle.P1 = ap.point;
            }
        }

        private void P2Button_Click(object sender, EventArgs e)
        {
            ap = new AddPoint();
            if (ap.ShowDialog() == DialogResult.OK)
            {
                triangle.P2 = ap.point;
            }
        }

        private void P3Button_Click(object sender, EventArgs e)
        {
            ap = new AddPoint();
            if (ap.ShowDialog() == DialogResult.OK)
            {
                triangle.P3 = ap.point;
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            if(triangle.P1 != null && triangle.P2 != null && triangle.P3 != null)
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
            }
            else
            {
                MessageBox.Show("not enough points");
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
