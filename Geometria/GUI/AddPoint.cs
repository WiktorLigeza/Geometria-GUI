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
    public partial class AddPoint : Form
    {
        public PointModel point = new PointModel();
        double x = 0, y = 0;
        public string color;
        public AddPoint()
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

            if (double.TryParse(textBoxX.Text, out x) && double.TryParse(textBoxY.Text, out y))
            {
                point.x = x;
                point.y = y;
            }
            else
            {
                MessageBox.Show("Invalid data set");
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
