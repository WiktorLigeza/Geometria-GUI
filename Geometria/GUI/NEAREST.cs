using Geometria.Models;
using Geometria.KDT;
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
    public partial class NEAREST : Form
    {
        public PointModel point = new PointModel();
        public KDNode root = new KDNode();
        public List<PointModel> randomPointsList;
        public PointModel nearest;
        public KDTreeModel KDT;



        /// <summary>
        /// input data
        /// </summary>
        double x = 0, y = 0;
        int elements = 0;



        public NEAREST()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            randomPointsList = new List<PointModel>();
            KDT = new KDTreeModel();

            if (validate())
            {
                point.x = x;
                point.y = y;
                generateRandomPoints();
                KDT.createKDT(randomPointsList);
                nearest = KDT.findNearest(point);
                this.Close();
                
            }

            else
            {
                MessageBox.Show("Invalid data set, please try again ;)");
                this.DialogResult = DialogResult.None;
                this.DialogResult = DialogResult.None;
                // refresh form
                textBoxX.Text = null;
                textBoxY.Text = null;
                textBoxElemetns.Text = null;
            }
        }

        bool validate()
        {
            bool output = true;


            if (!double.TryParse(textBoxX.Text, out x))
            {
                output = false;
            }
            if (!double.TryParse(textBoxY.Text, out y))
            {
                output = false;
            }
            if (!int.TryParse(textBoxElemetns.Text, out elements))
            {
                output = false;
            }

            return output;
        }


        void generateRandomPoints()
        {
            Random random = new Random();
            for (int i = 0; i < elements; i++)
            {
                PointModel p = new PointModel();

                p.x = random.Next(-150, 150);
                p.y = random.Next(-120, 120);

                randomPointsList.Add(p);
            }
        }

    }
  
}
