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
    public partial class AddPoligon : Form
    {
        public List<PointModel> PolygonVertices = new List<PointModel>();
        int elements;
        public string color;
        AddPoint ap;
        public AddPoligon()
        {
            InitializeComponent();
     
        }

   
      
        private void createPolygon()
        {
            for(int i = 0; i < elements; i++)
            {
                ap = new AddPoint();
                if (ap.ShowDialog() == DialogResult.OK)
                {
                    PolygonVertices.Add(ap.point);
                }
            }
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

            if (random.Checked == false && own.Checked == false)
            {
                MessageBox.Show("select own/random");
                this.DialogResult = DialogResult.None;
            }
        }

        private void generateRandom()
        {
            Random random = new Random();
            for (int i = 0; i < elements; i++)
            {
                PointModel p = new PointModel();

                p.x = random.Next(-150, 150);
                p.y = random.Next(-120, 120);

                PolygonVertices.Add(p);
            }
        }

  

       

        private void textBoxVertices_TextChanged(object sender, EventArgs e)
        {

        }

        private void own_CheckedChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxVertices.Text, out elements))
            {

                createPolygon();

            }
            else
            {
                MessageBox.Show("wrong data set");
                this.DialogResult = DialogResult.None;
            }
        }

        private void random_CheckedChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxVertices.Text, out elements))
            {

                generateRandom();

            }
            else
            {
                MessageBox.Show("wrong data set");
                this.DialogResult = DialogResult.None;
            }
           
        }

        private void textBoxVertices_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

        }
    }
}
