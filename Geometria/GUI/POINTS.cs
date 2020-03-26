using Geometria;
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
        /////////////////////////////////////////////////////////////////DECLARATIONS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        PointModel point = new PointModel();
        PointModel intersection1 = new PointModel();
        PointModel intersection2 = new PointModel();
        double r;
        PointModel center = new PointModel();
        KDNode root = new KDNode();
        List<PointModel> randomPointsList;
        List<PointModel> PolygonVertices;
        PointModel nearest;
        LineModel line = new LineModel();
        Computador computo = new Computador();
        TriangleModel triangle = new TriangleModel();
        int elements;
        double[] arr = new double[2];


        /// <summary>
        /// center of graph - coordinates
        /// </summary>
        int center_x, center_y;

       
        //graphic set
        Graphics g = null;
        Pen axis = new Pen(Color.Black);
        Pen PenLine = new Pen(Color.Red);
        Pen PenCircle = new Pen(Color.LightBlue);
        Pen PenExtention = new Pen(Color.Gray);


        /////////////////////////////////////////////////////////////////INTERACTION\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        public POINTS()
        {
            InitializeComponent();

            //setting center point of graph
            center_x = graph.Width / 2;
            center_y = graph.Height / 2;
        }




        /////////////////////////////////////////////////////////////////GRAPH DESIGN\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        public void graph_Paint(object sender, PaintEventArgs e)
        {
            g = graph.CreateGraphics();
            setGraph();
        }

        public void setGraph()
        {
            axis.Width = 2;
            g.DrawLine(axis, 3, center_y, graph.Width - 3, center_y);
            g.DrawLine(axis, center_x, 3, center_x, graph.Height - 3);
        }

        public void loadBar()
        {
            labelPoint.Text = ("X: " + point.x + "   Y: " + point.y);
            labelNearest.Text = ("X: " + nearest.x + "   Y: " + nearest.y);
            labelVector.Text = ("V: " + (float)lenght());
        }


        /////////////////////////TASKS
        //NEAREST
        public void putPoints()
        {
            foreach (PointModel p in randomPointsList)
            {
                g.FillEllipse(Brushes.Black, (float)p.x+center_x-3,-1*(float)p.y+center_y-3, 5, 5);
            }

            g.FillEllipse(
                Brushes.Red,
                (float)point.x + center_x - 3,
                -1*(float)point.y + center_y - 3,
                5,
                5 );
            g.FillEllipse(
                Brushes.Green,
                (float)nearest.x + center_x - 3,
                -1*(float)nearest.y + center_y - 3,
                5,
                5 );
        }

        //ZAD 1
        public void putSide()
        {
            //POINT
            g.FillEllipse(
                Brushes.Green,
                (float)point.x + center_x - 3,
                -1*(float)point.y + center_y - 3, 5, 5);

            //LINE
            g.DrawLine(
                PenLine,
                (float)line.A.x + center_x,
                -1*(float)line.A.y + center_y,
                (float)line.B.x + center_x,
                -1*(float)line.B.y + center_y);
        }

        //ZAD 2
        public void putTriangle()
        {
            g.FillEllipse(
              Brushes.Green,
              (float)point.x + center_x - 3,
              -1 * (float)point.y + center_y - 3, 5, 5);

            //triangle
            g.DrawLine(
               PenLine,
               (float)triangle.P1.x + center_x,
               -1 * (float)triangle.P1.y + center_y,
               (float)triangle.P2.x + center_x,
               -1 * (float)triangle.P2.y + center_y);
            g.DrawLine(
               PenLine,
              (float)triangle.P1.x + center_x,
               -1 * (float)triangle.P1.y + center_y,
               (float)triangle.P3.x + center_x,
               -1 * (float)triangle.P3.y + center_y );
            g.DrawLine(
                PenLine,
                (float)triangle.P2.x + center_x,
               -1 * (float)triangle.P2.y + center_y,
                 (float)triangle.P3.x + center_x,
               -1 * (float)triangle.P3.y + center_y );
        }

        //ZAD 3
        public void putPolygon()
        {
           //POINT
            g.FillEllipse(
             Brushes.Green,
             (float)point.x + center_x - 3,
             -1 * (float)point.y + center_y - 3, 5, 5);

           //POLYGON
           for(int i = 0; i<elements-1; i++)
            {
                g.DrawLine(
                 PenLine,
                 (float)PolygonVertices[i].x + center_x,
                 -1 * (float)PolygonVertices[i].y + center_y,
                 (float)PolygonVertices[i+1].x + center_x,
                 -1 * (float)PolygonVertices[i+1].y + center_y);
            }
            g.DrawLine(
                 PenLine,
                 (float)PolygonVertices[0].x + center_x,
                 -1 * (float)PolygonVertices[0].y + center_y,
                 (float)PolygonVertices[elements-1].x + center_x,
                 -1 * (float)PolygonVertices[elements-1].y + center_y);
        }
      
        //ZAD 4
        public void putCricle()
        {
            //center
            g.FillEllipse(
             Brushes.LightBlue,
             (float)center.x + center_x - 3,
             -1 * (float)center.y + center_y - 3, 5, 5);


            //Cirecle
            float size = (float)r * 2;
            g.DrawEllipse(
             PenCircle,
             (float)center.x + center_x - size/2,
             -1 * (float)center.y + center_y - size/2, size, size);

            //line extention
            LineModel extended = extendLIne(line);
            g.DrawLine(
              PenExtention,
              (float)extended.A.x + center_x,
              -1 * (float)extended.A.y + center_y,
              (float)extended.B.x + center_x,
              -1 * (float)extended.B.y + center_y);

            //line
            g.DrawLine(
               PenLine,
               (float)line.A.x + center_x,
               -1 * (float)line.A.y + center_y,
               (float)line.B.x + center_x,
               -1 * (float)line.B.y + center_y);

            //intersection
            int m = corssingPoint(center, line, r);
            if (m == 2)
            {
                g.FillEllipse(
                  Brushes.Green,
                  (float)intersection1.x + center_x - 3,
                  -1 * (float)intersection1.y + center_y - 3, 5, 5);

                g.FillEllipse(
                  Brushes.Green,
                  (float)intersection2.x + center_x - 3,
                  -1 * (float)intersection2.y + center_y - 3, 5, 5);

                MessageBox.Show("two intersections");
            }
            else if (m == 1)
            {
                g.FillEllipse(
                  Brushes.Green,
                  (float)intersection1.x + center_x - 3,
                  -1 * (float)intersection1.y + center_y - 3, 5, 5);

                MessageBox.Show("one intersection");
            }
            else { MessageBox.Show("no intersections found"); }

        }

        ////////////////////////////////////////////////////////////////MOUSE COORDINATES\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void graph_MouseMove(object sender, MouseEventArgs e)
        {
            labelAxis.Text = ("X: " + (e.X-center_x) + "   Y: " + (-1*(e.Y-center_y)));
        }

        private void graph_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("POINT: X: " + (e.X - center_x) + " Y: " + (-1 * (e.Y - center_y)));
        }



        ////////////////////////////////////////////////////////////////////BUTTONS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //REFRESH
        private void refresh_Click(object sender, EventArgs e)
        {
            graph.Refresh();
        }

        //FIND NEAREST
        private void menuKDTButton_Click(object sender, EventArgs e)
        {
            graph.Refresh();
            NEAREST n = new NEAREST();
            if(n.ShowDialog() == DialogResult.OK)
            {
                randomPointsList = n.randomPointsList;
                root = n.root;
                point = n.point;
                nearest = n.nearest;
            }
            putPoints();
            loadBar();
        }

        //ZAD 1
        private void SIDE_Click(object sender, EventArgs e)
        {
            graph.Refresh();
            SIDE s = new SIDE();
            if (s.ShowDialog() == DialogResult.OK)
            {
                point = s.point;
                line = s.line;
            }
            putSide();

            if (0 > computo.side(point, line))
            {
                MessageBox.Show("left side");
            }
            else if (0 < computo.side(point, line))
            {
                MessageBox.Show("right side");
            }
            else
            {
                MessageBox.Show("on");
            }
            
        }

        //ZAD 2
        private void zad2_Click(object sender, EventArgs e)
        {
            randomTriangle();
            putTriangle();
            if (isItInsideTriangle(triangle)) { MessageBox.Show("INSIDE ;D"); }
            else { MessageBox.Show("OUTSIDE ;D"); }
            graph.Refresh();


        }

        //ZAD 3
        private void zad3_Click(object sender, EventArgs e)
        {
            //POLYGON p = new POLYGON();
            //if (p.ShowDialog() == DialogResult.OK)
            //{
            //    PolygonVertices = p.PolygonVertices;
            //    elements = p.elements;
            //}
            randomPolygon();
            putPolygon();
            if (isItInsidePolygon()) { MessageBox.Show("INSIDE ;D"); }
            else { MessageBox.Show("OUTSIDE ;D"); }
            graph.Refresh();

        }

        //ZAD 4
        private void zad4_Click(object sender, EventArgs e)
        {
            graph.Refresh();
            Circle c = new Circle();
            if (c.ShowDialog() == DialogResult.OK)
            {
                center = c.point;
                line = c.line;
                r = c.r;
            }
            putCricle();

        }





        ////////////////////////////////COMPUTE\\\\\\\\\\\\\\\\\\\\\\\\\\\\ - should've been implemented in another class - will fix later  
        //TODO - fix it

        double lenght()
        {
            if (point != null && nearest != null)
            {
                return Math.Sqrt((nearest.x - point.x) * (nearest.x - point.x) + (nearest.y - point.y) * (nearest.y - point.y));
            }
            else return 0;

        }

        LineModel extendLIne(LineModel line)
        {
            LineModel l = new LineModel();
           
            double[] arr = computo.SLE(line); //arr = {a,b}

            if (arr[0] >= 0)
            {
                l.A.x = 215;
                l.B.x = -215;
            }
            else if (arr[0] < 0)
            {
                l.A.x = -215;
                l.B.x = 215;
            }
          

            l.A.y = arr[0] * l.A.x + arr[1];

            l.B.y = arr[0] * l.B.x + arr[1];

            return l;
        }

        //ZAD 2
        void randomTriangle()
        {
            Random random = new Random();
            //point.x = 5;
            //point.y = 5;
            point.x = random.Next(-150, 150);
            point.y = random.Next(-120, 120);
            triangle.P1.x = random.Next(-150, 150);
            triangle.P1.y = random.Next(-120, 120);
            triangle.P2.x = random.Next(-150, 150);
            triangle.P2.y = random.Next(-120, 120);
            triangle.P3.y = random.Next(-120, 120);
            triangle.P3.y = random.Next(-120, 120);
        }

        bool isItInsideTriangle(TriangleModel t)
        {
            //math
            double s1 = t.P3.y - t.P1.y;
            double s2 = t.P3.x - t.P1.x;
            double s3 = t.P2.y - t.P1.y;
            double s4 = point.y - t.P1.y;

            double w1 = (t.P1.x * s1 + s4 * s2 - point.x * s1) / (s3 * s2 - (t.P2.x - t.P1.x) * s1);
            double w2 = (s4 - w1 * s3) / s1;


            //is it ?
            if (w1 >= 0 && w2 >= 0 && (w1 + w2) <= 1) return true;
            else return false;

        }

        //ZAD 3 
        void randomPolygon()
        {
            PolygonVertices = new List<PointModel>();
            Random random = new Random();
            //point.x = 5;
            //point.y = 5;
            point.x = random.Next(-150, 150);
            point.y = random.Next(-120, 120);

            elements = random.Next(3, 10);
            for (int i = 0; i < elements; i++)
            {
                PointModel p = new PointModel();

                p.x = random.Next(-150, 150);
                p.y = random.Next(-120, 120);

                PolygonVertices.Add(p);
            }
        }

        bool isItInsidePolygon()
        {
            TriangleModel t;
            int k = 0;
            for (int i = 1; i < elements - 1; i++)
            {
                t = new TriangleModel();
                t.P1 = PolygonVertices[0];
                t.P2 = PolygonVertices[i];
                t.P3 = PolygonVertices[i + 1];

                if (isItInsideTriangle(t)) { k++; }
            }
            if (k % 2 == 0) { return false; } //even
            else return true;  //odd
        }

        //ZAD 4
        int corssingPoint(PointModel center, LineModel line, double r)
        {
            double kx;
            double ky;
            double dx = line.B.x - line.A.x;
            double dy = line.B.y - line.A.y;

            double a = dx * dx + dy * dy;
            double b = 2 * (dx * (line.A.x - center.x) + dy * (line.A.y - center.y));
            double c = (line.A.x - center.x) * (line.A.x - center.x) + (line.A.y - center.y) * (line.A.y - center.y) - r* r;



            double delta = b * b - 4 * a * c;
            int i;

            if (delta > 0) 
            {
                // two solutions
                kx = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                intersection1.x = line.A.x + kx * dx;
                intersection1.y = line.A.y + kx * dy;


                ky = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                intersection2.x = line.A.x + ky * dx;
                intersection2.y = line.A.y + ky * dy;

                return 2;
            }
            else if (delta == 0)
            {
                // one solution
                kx = -b / (2 * a);

                intersection1.x = line.A.x + kx * dx;
                intersection1.y = line.A.y + kx * dy;
                
                return 1;
            }
            else return 0;

           

        }























        ////////////////////////////////TRASH\\\\\\\\\\\\\\\\\\\\\\\\\\\\ - not able to delete
        private void labelX_Click(object sender, EventArgs e)
        {

        }

        private void POINTS_Load(object sender, EventArgs e)
        {

        }

        private void POINTS_MouseMove(object sender, MouseEventArgs e)
        {

        }

        //double x1Sqr = line.A.x * line.A.x;
        //double y1Sqr = line.A.y * line.A.y;
        //double x2Sqr = line.B.x * line.B.x;
        //double y2Sqr = line.B.y * line.B.y;
        //double cxSqr = center.x * center.x;
        //double cySqr = center.y * center.y;

        //double a = x1Sqr + y1Sqr + x2Sqr + y2Sqr - 2*(line.B.x * line.B.x + line.A.y + line.B.y);
        //double b = 2 * (center.x * (line.B.x - line.A.x) + center.y * (line.B.y - line.A.y)
        //    + line.A.x * line.B.x + line.A.y * line.B.y - x2Sqr - y2Sqr);
        //double c = -1 * (r * r) + x2Sqr + y2Sqr + cxSqr + cySqr - 2 * (center.x * line.B.x + center.y * line.B.y);
    }
}
