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
    public partial class AddCircle : Form
    {
        
        public CircleModel circle = new CircleModel();
        public string color;
        public AddCircle()
        {
            InitializeComponent();
        }

        double x, y, r;

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

            if (double.TryParse(textBoxX.Text, out x) && double.TryParse(textBoxY.Text, out y) && double.TryParse(textBoxR.Text, out r))
            {
                circle.center.x = x;
                circle.center.y = y;
                circle.r = r;
            }
            else
            {
                MessageBox.Show("Invalid data set");
                this.DialogResult = DialogResult.None;
            }
            if (r <= 0)
            {
                MessageBox.Show("Invalid: r <= 0");
                this.DialogResult = DialogResult.None;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
