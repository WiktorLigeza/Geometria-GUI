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
    public partial class POLYGON : Form
    {
        public List<PointModel> PolygonVertices = new List<PointModel>();
        public int elements;


        public POLYGON()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elements = int.Parse(textBoxVertices.Text);
            Random random = new Random();
            for (int i = 0; i < elements; i++)
            {
                PointModel p = new PointModel();

                p.x = random.Next(-150, 150);
                p.y = random.Next(-120, 120);

                PolygonVertices.Add(p);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
