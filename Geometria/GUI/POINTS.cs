using Geometria.KDT;
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
    public partial class POINTS : Form
    {
        ////////////////////////////////////DECLARATIONS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        /// <summary>
        /// center of graph - coordinates
        /// </summary>
        int center_x, center_y;

        /// <summary>
        /// input data
        /// </summary>
        int x = 0, y = 0, elements = 0;

        List<PointModel> randomPointsList;

        PointModel point = new PointModel();
        PointModel nearest;
        KDTreeModel KDT;

        //graphic set
        Graphics g = null;
        Pen axis = new Pen(Color.Black);


        ////////////////////////////////////INTERACTION\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        public POINTS()
        {
            InitializeComponent();

            //setting center point of graph
            center_x = graph.Width / 2;
            center_y = graph.Height / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //refresh
            graph.Refresh();
            randomPointsList = new List<PointModel>();
            KDT = new KDTreeModel();

            if (validate())
            {
                point.x = x;
                point.y = y;
                generateRandomPoints();
                KDT.createKDT(randomPointsList);
                nearest = KDT.findNearest(point);
                putPoints();
                loadBar();
            }

            else
            {
                MessageBox.Show("Invalid data set, please try again ;)");

                //refresh form
                textBoxX.Text = null;
                textBoxY.Text = null;
                textBoxElemetns.Text = null;
            }
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
            if (!int.TryParse(textBoxElemetns.Text, out elements))
            {
                output = false;
            }

            return output;
        }

        
        ////////////////////////////////GRAPH DESIGN\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void graph_Paint(object sender, PaintEventArgs e)
        {
            g = graph.CreateGraphics();
            setGraph();
        }

        /// <summary>
        /// sets points on graph
        /// </summary>
        void putPoints()
        {
            foreach (PointModel p in randomPointsList)
            {
                g.FillEllipse(Brushes.Black, (float)p.x+center_x-3,-1*(float)p.y+center_y-3, 5, 5);
            }

            g.FillEllipse(Brushes.Red, (float)point.x + center_x - 3, -1 * (float)point.y + center_y - 3, 5, 5);
            g.FillEllipse(Brushes.Green, (float)nearest.x + center_x - 3, -1 * (float)nearest.y + center_y - 3, 5, 5);
        }

        void setGraph()
        {
            axis.Width = 2;
            g.DrawLine(axis, 3, center_y, graph.Width-3, center_y);
            g.DrawLine(axis, center_x, 3, center_x, graph.Height-3);
        }

        void loadBar()
        {
            labelPoint.Text = ("X: " + point.x + "   Y: " + point.y);
            labelNearest.Text = ("X: " + nearest.x + "   Y: " + nearest.y);
            labelVector.Text = ("V: " +(float)lenght());
        }


        ////////////////////////////////MOUSE COORDINATES\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void graph_MouseMove(object sender, MouseEventArgs e)
        {
            labelAxis.Text = ("X: " + (e.X-center_x) + "   Y: " + (-1*(e.Y-center_y)));
        }

        private void graph_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("POINT: X: " + (e.X - center_x) + " Y: " + (-1 * (e.Y - center_y)));
        }


        ////////////////////////////////COMPUTE\\\\\\\\\\\\\\\\\\\\\\\\\\\\
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

        double lenght()
        {
            if (point != null && nearest != null)
            {
                return Math.Sqrt((nearest.x - point.x) * (nearest.x - point.x) + (nearest.y - point.y) * (nearest.y - point.y));
            }
            else return 0;

        }



        ////////////////////////////////TRASH\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void labelX_Click(object sender, EventArgs e)
        {

        }

        private void POINTS_Load(object sender, EventArgs e)
        {

        }

        private void POINTS_MouseMove(object sender, MouseEventArgs e)
        {

        }


    }
}

///////////////////////DUMPSTER\\\\\\\\\\\\\\\\\\\\