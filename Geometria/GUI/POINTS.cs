using FSharpx.Collections;
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
        KDNode root;
        List<PointModel> randomPointsList;
        List<PointModel> PolygonVertices;
        List<LineModel> newLinesList = new List<LineModel>();
        List<PointModel> newPointsList = new List<PointModel>();
        PointModel nearest;
        LineModel line = new LineModel();
        Computador computo = new Computador();
        TriangleModel triangle = new TriangleModel();
        List<TriangleModel> newTriangleList = new List<TriangleModel>();
        List<List<PointModel>> newPolygonsList = new List<List<PointModel>>();
        List<CircleModel> newCirclesList = new List<CircleModel>();
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


        /////////////////////////////////////////////////////////////////INIT\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
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
            if(nearest != null)
            {
                labelNearest.Text = ("X: " + nearest.x + "   Y: " + nearest.y);
            }
            labelVector.Text = ("V: " + (float)lenght());
        }


        /////////////////////////PUT ON CANVAS
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
            if(nearest!=null)
            {
                g.FillEllipse(
                Brushes.Green,
                (float)nearest.x + center_x - 3,
                -1 * (float)nearest.y + center_y - 3,
                5,
                5);
            }
            
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

        //Add Point
        public void putNewPoint(PointModel newPoint, string color)
        {
           // newPointsList.Add(newPoint);
            if (color == "green")
            {
                g.FillEllipse(
                Brushes.Green,
                (float)newPoint.x + center_x - 3,
                -1 * (float)newPoint.y + center_y - 3,
                 5,
                 5);
            }
            else if (color == "red")
            {
                g.FillEllipse(
               Brushes.Red,
               (float)newPoint.x + center_x - 3,
               -1 * (float)newPoint.y + center_y - 3,
                5,
                5);
            }
            else if (color == "pink")
            {
                g.FillEllipse(
               Brushes.Pink,
               (float)newPoint.x + center_x - 3,
               -1 * (float)newPoint.y + center_y - 3,
                5,
                5);
            }
            else
            {
                g.FillEllipse(
               Brushes.Black,
               (float)newPoint.x + center_x - 3,
               -1 * (float)newPoint.y + center_y - 3,
                5,
                5);
            }
           
        }

        //Add Line
        public void putNewLine(LineModel line, string color,double[]SLE)
        {
            Pen NewLinePen;
            //set color
            if (color == "green")
            {
                 NewLinePen = new Pen(Color.Green,2);
            }
            else if (color == "red")
            {
                 NewLinePen = new Pen(Color.Red,2);
            }
            else if (color == "pink")
            {
                 NewLinePen = new Pen(Color.Pink, 2);
            }
            else if (color == "gray")
            {
                NewLinePen = new Pen(Color.LightGray, 2);
            }
            else
            {
                 NewLinePen = new Pen(Color.Black, 2);
            }

            //draw line
            if (line != null)
            {
                //newLinesList.Add(line);
                g.DrawLine(
                 NewLinePen,
                 (float)line.A.x + center_x,
                 -1 * (float)line.A.y + center_y,
                (float)line.B.x + center_x,
                 -1 * (float)line.B.y + center_y);
            }
            else
            {
                LineModel l = new LineModel();
                if (SLE[0] >= 0)
                {
                    l.A.x = 215;
                    l.B.x = -215;
                }
                else if (SLE[0] < 0)
                {
                    l.A.x = -215;
                    l.B.x = 215;
                }
                l.A.y = SLE[0] * l.A.x + SLE[1];
                l.B.y = SLE[0] * l.B.x + SLE[1];
                //newLinesList.Add(l);
                g.DrawLine(
                 NewLinePen,
                 (float)l.A.x + center_x,
                 -1 * (float)l.A.y + center_y,
                 (float)l.B.x + center_x,
                 -1 * (float)l.B.y + center_y);
            }
           
        }

        //Add Triangle
        public void putNewTriangle(TriangleModel triangle, string color)
        {
            Pen NewLinePen;
            //set color
            if (color == "green")
            {
                NewLinePen = new Pen(Color.Green, 2);
            }
            else if (color == "red")
            {
                NewLinePen = new Pen(Color.Red, 2);
            }
            else if (color == "pink")
            {
                NewLinePen = new Pen(Color.Pink, 2);
            }
            else
            {
                NewLinePen = new Pen(Color.Black, 2);
            }
            g.DrawLine(
              NewLinePen,
              (float)triangle.P1.x + center_x,
              -1 * (float)triangle.P1.y + center_y,
              (float)triangle.P2.x + center_x,
              -1 * (float)triangle.P2.y + center_y);
            g.DrawLine(
               NewLinePen,
              (float)triangle.P1.x + center_x,
               -1 * (float)triangle.P1.y + center_y,
               (float)triangle.P3.x + center_x,
               -1 * (float)triangle.P3.y + center_y);
            g.DrawLine(
                NewLinePen,
                (float)triangle.P2.x + center_x,
               -1 * (float)triangle.P2.y + center_y,
                 (float)triangle.P3.x + center_x,
               -1 * (float)triangle.P3.y + center_y);
        }

        //Add Polygon
        public void putNewPolygon(List<PointModel> PolygonVertices, string color)
        {
            Pen NewLinePen;
            //set color
            if (color == "green")
            {
                NewLinePen = new Pen(Color.Green, 2);
            }
            else if (color == "red")
            {
                NewLinePen = new Pen(Color.Red, 2);
            }
            else if (color == "pink")
            {
                NewLinePen = new Pen(Color.Pink, 2);
            }
            else
            {
                NewLinePen = new Pen(Color.Black, 2);
            }
            

            for (int i = 0; i < PolygonVertices.Count - 1; i++)
            {
                g.DrawLine(
                 NewLinePen,
                 (float)PolygonVertices[i].x + center_x,
                 -1 * (float)PolygonVertices[i].y + center_y,
                 (float)PolygonVertices[i + 1].x + center_x,
                 -1 * (float)PolygonVertices[i + 1].y + center_y);
            }
            g.DrawLine(
                 NewLinePen,
                 (float)PolygonVertices[0].x + center_x,
                 -1 * (float)PolygonVertices[0].y + center_y,
                 (float)PolygonVertices[PolygonVertices.Count - 1].x + center_x,
                 -1 * (float)PolygonVertices[PolygonVertices.Count - 1].y + center_y);
        }

        //Add Circle
        public void putNewCircle(CircleModel circle, string color)
        {
            Pen NewLinePen;
            //set color
            if (color == "green")
            {
                NewLinePen = new Pen(Color.Green, 2);
            }
            else if (color == "red")
            {
                NewLinePen = new Pen(Color.Red, 2);
            }
            else if (color == "pink")
            {
                NewLinePen = new Pen(Color.Pink, 2);
            }
            else
            {
                NewLinePen = new Pen(Color.Black, 2);
            }

            //Center
            putNewPoint(circle.center, color);


            //Cirecle
            float size = (float)circle.r * 2;
            g.DrawEllipse(
             NewLinePen,
             (float)circle.center.x + center_x - size / 2,
             -1 * (float)circle.center.y + center_y - size / 2, size, size);
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
            nearest = new PointModel();
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
                putPoints();
                loadBar();
            }
           
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
           
            
        }

        //ZAD 2
        private void zad2_Click(object sender, EventArgs e)
        {
            randomTriangle();
            putTriangle();
            if (isItInsideTriangle(point,triangle)) { MessageBox.Show("INSIDE ;D"); }
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
            if (isItInsidePolygon(PolygonVertices, point)) { MessageBox.Show("INSIDE ;D"); }
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
                putCricle();
            }

        }

        //PROJECT
        /// <summary>
        /// adds new point
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            PointModel newPoint = new PointModel();
            AddPoint ap = new AddPoint();
            if (ap.ShowDialog() == DialogResult.OK)
            {
                newPoint = ap.point;
                newPointsList.Add(newPoint);
                putNewPoint(newPoint, ap.color);
            }
           
        }
        /// <summary>
        /// adds new line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            LineModel newLine = new LineModel();
            AddLine al = new AddLine();
            double[] SLE = new double[2];
            if (al.ShowDialog() == DialogResult.OK)
            {
                newLine = al.line;
                SLE = al.SLE;
                if(newLine == null)
                {
                    newLine = new LineModel();
                    if (SLE[0] >= 0)
                    {
                        newLine.A.x = 215;
                        newLine.B.x = -215;
                    }
                    else if (SLE[0] < 0)
                    {
                        newLine.A.x = -215;
                        newLine.B.x = 215;
                    }
                    newLine.A.y = SLE[0] * newLine.A.x + SLE[1];
                    newLine.B.y = SLE[0] * newLine.B.x + SLE[1];
                    newLinesList.Add(newLine);
                }
                else newLinesList.Add(newLine);
                putNewLine(newLine, al.color, SLE);
            }
        }
        /// <summary>
        /// adds new triangle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTraingleButton_Click(object sender, EventArgs e)
        {
            TriangleModel triangle = new TriangleModel();
            AddTriangle at = new AddTriangle();
            if (at.ShowDialog() == DialogResult.OK)
            {
                triangle = at.triangle;
                putNewTriangle(triangle, at.color);
                newTriangleList.Add(triangle);
            }
            
        }
        /// <summary>
        /// adds new poligon 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPolygonButton_Click(object sender, EventArgs e)
        {
            AddPoligon aPol = new AddPoligon();
            if (aPol.ShowDialog() == DialogResult.OK)
            {
                putNewPolygon(aPol.PolygonVertices, aPol.color);
                newPolygonsList.Add(aPol.PolygonVertices);
            }
            
        }
        /// <summary>
        /// adds new ciercle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCircleButton_Click(object sender, EventArgs e)
        {
            AddCircle ac = new AddCircle();
            if (ac.ShowDialog() == DialogResult.OK)
            {
                putNewCircle(ac.circle, ac.color);
                newCirclesList.Add(ac.circle);
            }
            
        }


        // I - rotacja lini wzgledem punktu 
        private void buttonI_Click(object sender, EventArgs e)
        {
            Rotate rot = new Rotate(newLinesList);
            LineModel Lmodel = new LineModel();
            List<LineModel> added = new List<LineModel>();
            bool terms = true;
            double degree = 0;

            if (rot.ShowDialog() == DialogResult.OK)
            {
                Lmodel = rot.Lmodel;
                added = rot.list;
                degree = rot.degree;
                terms = rot.terms;
                int j = added.Count;
                if (rot.didAdd == true )
                {
                    for (int i = 0; i < j; i++)
                    {
                        putNewLine(added[i], rot.al.color, rot.SLE);
                    }
                }
                putNewLine(computo.rotation(Lmodel, degree, terms), "red", rot.SLE);
            }
           
        }

        // II - punkt przeciecia
        private void buttonII_Click(object sender, EventArgs e)
        {
            graph.Refresh();
            CrossinggPoint cp = new CrossinggPoint(newLinesList);
            List<LineModel> selected = new List<LineModel>();
            List<LineModel> added = new List<LineModel>();

            if (cp.ShowDialog() == DialogResult.OK)
            {
                added = cp.list;
                selected = cp.selectedList;

                int j = added.Count;
                if (cp.didAdd == true)
                {
                    for(int i = 0; i< j; i++)
                    {
                        putNewLine(added[i], cp.al.color, cp.SLE);
                    }
                }
                PointModel p = computo.CrossingPointerCramer(selected[0], selected[1]);
                putNewPoint(p, "red");
                MessageBox.Show("x:" + (float)p.x+", y:"+ (float)p.y);

            }
        }

        // III 
        private void buttonIII_Click(object sender, EventArgs e)
        {
            graph.Refresh();
            Line l = new Line(newLinesList, newPointsList);
            List<PointModel> addedPoints = new List<PointModel>();
            List<LineModel> addedLines = new List<LineModel>();
            if (l.ShowDialog() == DialogResult.OK)
            {
                addedPoints = l.pointsList;
                addedLines = l.lineList;

               
               

                int j = addedLines.Count;
                int k = addedPoints.Count;

                //putnew added 
                for (int i = 0; i < k; i++)
                {
                    putNewPoint(addedPoints[i], null);
                }

                for (int i = 0; i < j; i++)
                {
                    putNewLine(addedLines[i], null, l.SLE);
                }

                //put selected
                putNewPoint(l.point, "red");
                putNewLine(l.line, "green", l.SLE);

                if (0 > computo.side(l.point, l.line))
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

        }

        //IV
        private void buttonIV_Click(object sender, EventArgs e)
        {
            graph.Refresh();
            Triangle t = new Triangle(newTriangleList, newPointsList);
            List<PointModel> addedPoints = new List<PointModel>();
            List<TriangleModel> addedTriangles = new List<TriangleModel>();

            if (t.ShowDialog() == DialogResult.OK)
            {
                addedPoints = t.pointsList;
                addedTriangles = t.triangleList;
                

                int j = addedTriangles.Count;
                int k = addedPoints.Count;

                //putnew added 
                for (int i = 0; i < k; i++)
                {
                    putNewPoint(addedPoints[i], null);
                }

                for (int i = 0; i < j; i++)
                {
                    putNewTriangle(addedTriangles[i], null);
                }

                //put selected
                putNewPoint(t.point, "red");
                putNewTriangle(t.triangle, "green");

                if (isItInsideTriangle(t.point, t.triangle)) { MessageBox.Show("INSIDE ;D"); }
                else { MessageBox.Show("OUTSIDE ;D"); }

            }
        }

        //V
        private void buttonV_Click(object sender, EventArgs e)
        {
            graph.Refresh();
            PolygonSide ps = new PolygonSide(newPointsList);
            if (ps.ShowDialog() == DialogResult.OK)
            {
                putNewPolygon(ps.PolygonVertices, ps.aPol.color);
                putNewPoint(ps.point, "red");
                if (isItInsidePolygon(ps.PolygonVertices,ps.point)) { MessageBox.Show("INSIDE ;D"); }
                else { MessageBox.Show("OUTSIDE ;D"); }
            }
        }

        //VI
        private void buttonVI_Click(object sender, EventArgs e)
        {
            graph.Refresh();
            circleIntersection ac = new circleIntersection(newLinesList,newCirclesList);
            if (ac.ShowDialog() == DialogResult.OK)
            {
                int j = newCirclesList.Count;
                int k = newLinesList.Count;

                //putnew added 
                for (int i = 0; i < j; i++)
                {
                    putNewCircle(newCirclesList[i], null);
                }
               

                for (int i = 0; i < k; i++)
                {
                    putNewLine(newLinesList[i], null, ac.SLE );
                }

                LineModel extended = extendLIne(ac.line);
                putNewLine(extended, "gray", ac.SLE);

                //put selected
                putNewCircle(ac.circle, "pink");
                putNewLine(ac.line, "green", ac.SLE);

                //intersection
                int m = corssingPoint(ac.circle.center, ac.line, ac.circle.r);
                if (m == 2)
                {
                    putNewPoint(intersection1, "red");
                    putNewPoint(intersection2, "red");

                    MessageBox.Show("two intersections at, x:" + (float)intersection1.x + ", y:" + (float)intersection1.y +
                        "and x:" + (float)intersection2.x + ", y:" + (float)intersection2.y);
                }
                else if (m == 1)
                {
                    putNewPoint(intersection1, "red");
                    MessageBox.Show("one intersection at, x:" + (float)intersection1.x + ", y:" + (float)intersection1.y);
                }
                else { MessageBox.Show("no intersections found"); }

            }
        }

        private void buttonVII_Click(object sender, EventArgs e)
        {
            graph.Refresh();
            triangleArea ta = new triangleArea(newTriangleList);
            if (ta.ShowDialog() == DialogResult.OK)
            {
                int j = newTriangleList.Count;

                //putnew added 
                for (int i = 0; i < j; i++)
                {
                    putNewTriangle(newTriangleList[i], null);
                }

                //put selected
                putNewTriangle(ta.triangle, "red");
                MessageBox.Show("area: " + Math.Abs(ta.area));
            }

        }

        // 3 a
        private void button3a_Click(object sender, EventArgs e)
        {
            randomPointsList = new List<PointModel>();
            graph.Refresh();
            generateRandomPoints();
            List<PointModel> list = randomPointsList;
            convexHull(list);
        }
        // 3 b
        private void button3b_Click(object sender, EventArgs e)
        {
            Refresh();
            generateRandomPoints();
            KDTreeModel KDT = new KDTreeModel();
            LineModel line = new LineModel();
            PointModel temp = new PointModel();
            //KDT.createKDT(randomPointsList);
            nearest = new PointModel();
            putPoints();
            while (randomPointsList.Count > 3)
            {
                for (int i = 0; i < randomPointsList.Count; i++)
                {
                    System.Threading.Thread.Sleep(500);
                    double x = randomPointsList[i].x;
                    double y = randomPointsList[i].y;

                    temp.x = x;
                    temp.y = y;

                    randomPointsList.Remove(randomPointsList[i]);
                    KDT = new KDTreeModel();
                    KDT.createKDT(randomPointsList);

                    nearest = KDT.findNearest(temp);

                    //set line
                    line.B.x = x;
                    line.B.y = y;
                    line.A.x = nearest.x;
                    line.A.y = nearest.y;

                    randomPointsList.Remove(nearest);
                    putNewLine(line, "red", null);

                }
            }
            if(randomPointsList.Count >= 2)
            {
                line.B.x = randomPointsList[0].x;
                line.B.y = randomPointsList[0].y;
                line.A.x = randomPointsList[1].x;
                line.A.y = randomPointsList[1].y;
                putNewLine(line, "red", null);
            }
           
            
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

        void generateRandomPoints()
        {
            randomPointsList = new List<PointModel>();
            Random random = new Random();
            elements = random.Next(10, 100);
            for (int i = 0; i < elements; i++)
            {
                PointModel p = new PointModel();

                p.x = random.Next(-150, 150);
                p.y = random.Next(-120, 120);

                randomPointsList.Add(p);
            }
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

        bool isItInsideTriangle(PointModel point,TriangleModel t)
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

        bool isItInsidePolygon(List<PointModel> PolygonVertices, PointModel point)
        {
            TriangleModel t;
            int k = 0;
            for (int i = 1; i < PolygonVertices.Count - 1; i++)
            {
                t = new TriangleModel();
                t.P1 = PolygonVertices[0];
                t.P2 = PolygonVertices[i];
                t.P3 = PolygonVertices[i + 1];

                if (isItInsideTriangle(point,t)) { k++; }
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


        //3 a
        void convexHull(List<PointModel> list)
        {
            putPoints();
            LineModel line = new LineModel();
            
            //set initial
            list.Sort((a, b) => a.x == b.x ? a.y.CompareTo(b.y) : a.x.CompareTo(b.x));

            double initialX = list[0].x;
            double initialY = list[0].y;
            List<PointModel> hull = GetHull(list);
            for (int i = 0; i < hull.Count - 1; i++)
            {
                line.A = hull[i];
                line.B = hull[i + 1];
                putNewLine(line, "green", null);
            }
            line.A = hull[0];
            line.B = hull[hull.Count-1];
            putNewLine(line, "green", null);

            foreach (PointModel p in hull)
            {
                putNewPoint(p, "pink");
            }

            //put init
            g.FillEllipse(
               Brushes.Blue,
               (float)initialX + center_x - 3,
               -1 * (float)initialY + center_y - 3,
               5,
               5);

        }

        public List<PointModel> GetHull(List<PointModel> list)
        {
            if (list == null)
                return null;

            if (list.Count() <= 1) //no hull
                return list;

            int size = list.Count(), j = 0;
            List<PointModel> stack = new List<PointModel>(new PointModel[2 * size]);

            list.Sort((a, b) =>
                 a.x == b.x ? a.y.CompareTo(b.y) : a.x.CompareTo(b.x));
           
            //lower
            for (int i = 0; i < size; ++i)
            {
                while (j >= 2 && computo.sideByPoints(stack[j - 2], stack[j - 1], list[i]) <= 0)
                    j--;
                stack[j++] = list[i];
            }

            //upper
            for (int i = size - 2, k = j + 1; i >= 0; i--)
            {
                while (j >= k && computo.sideByPoints(stack[j - 2], stack[j - 1], list[i]) <= 0)
                    j--;
                stack[j++] = list[i];
            }

            return stack.Take(j - 1).ToList();
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

      
    }
}



///////////////////////DUMPSTER\\\\\\\\\\\\\\\\\\\\\\\\\\ 
/////double x1Sqr = line.A.x * line.A.x;
//double y1Sqr = line.A.y * line.A.y;
//double x2Sqr = line.B.x * line.B.x;
//double y2Sqr = line.B.y * line.B.y;
//double cxSqr = center.x * center.x;
//double cySqr = center.y * center.y;

//double a = x1Sqr + y1Sqr + x2Sqr + y2Sqr - 2*(line.B.x * line.B.x + line.A.y + line.B.y);
//double b = 2 * (center.x * (line.B.x - line.A.x) + center.y * (line.B.y - line.A.y)
//    + line.A.x * line.B.x + line.A.y * line.B.y - x2Sqr - y2Sqr);
//double c = -1 * (r * r) + x2Sqr + y2Sqr + cxSqr + cySqr - 2 * (center.x * line.B.x + center.y * line.B.y);





//List<PointModel> above = new List<PointModel>();
//List<PointModel> below = new List<PointModel>();
// //split by y value
//foreach (PointModel point in list)
//{
//    if (point.y >= initialY)
//    {
//        above.Add(point);
//    }
//    else
//    {
//        below.Add(point);
//    }
//}

