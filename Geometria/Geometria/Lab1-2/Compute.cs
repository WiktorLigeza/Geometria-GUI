using Geometria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Compute
    {
        //add methods - lab 1 && lab 2
        public void addLine(LineModel line)
        {
            string input;

            ////////////////////////////GATHER DATA\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            Console.WriteLine("------------LINE-------------");
            ///A
            Console.WriteLine("enter A point's x coordinate :");
            input = Console.ReadLine();
            line.A.x = double.Parse(input);

            Console.WriteLine("enter A point's y coordinate :");
            input = Console.ReadLine();
            line.A.y = double.Parse(input);

            ///B
            Console.WriteLine("enter B point's x coordinate :");
            input = Console.ReadLine();
            line.B.x = double.Parse(input);

            Console.WriteLine("enter B point's y coordinate :");
            input = Console.ReadLine();
            line.B.y = double.Parse(input);

        }

        internal void addTriangle(TriangleModel triangle)
        {
            string input;

            ////////////////////////////GATHER DATA\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            Console.WriteLine("------------TRIANGLE-------------");
            ///P1
            Console.WriteLine("enter P1 point's x coordinate :");
            input = Console.ReadLine();
            triangle.P1.x = double.Parse(input);

            Console.WriteLine("enter P1 point's y coordinate :");
            input = Console.ReadLine();
            triangle.P1.y = double.Parse(input);

            //P2
            Console.WriteLine("enter P2 point's x coordinate :");
            input = Console.ReadLine();
            triangle.P2.x = double.Parse(input);

            Console.WriteLine("enter P2 point's y coordinate :");
            input = Console.ReadLine();
            triangle.P2.y = double.Parse(input);

            //P2
            Console.WriteLine("enter P3 point's x coordinate :");
            input = Console.ReadLine();
            triangle.P3.x = double.Parse(input);

            Console.WriteLine("enter P3 point's y coordinate :");
            input = Console.ReadLine();
            triangle.P3.y = double.Parse(input);

        }

        public void addPoint(PointModel point)
        {
            string input;

            ////////////////////////////GATHER DATA\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            Console.WriteLine("------------POINT-------------");
            Console.WriteLine("enter x coordinate :");
            input = Console.ReadLine();
            point.x = double.Parse(input);

            Console.WriteLine("enter y coordinate :");
            input = Console.ReadLine();
            point.y = double.Parse(input);
        }


        ////////////////////////////////////////// LAB 1
        /// <summary>
        /// straight line equation
        /// </summary>
        /// <param name="line"></param>
        public double[] SLE(LineModel line) 
        {
            double a,b;
            double[] result = new double[2];
            a = (line.A.y - line.B.y) / (line.A.x - line.B.x); //(y1 - y2) / (x1 - x2);
            b = line.A.y - a * line.A.x;  //y1 - a * x1;
            //Console.WriteLine("equation: y=" +a+"x+"+b);
            result[0] = a;
            result[1] = b;
        
            return result;
        }

        public void vector(LineModel line)
        {
            double x, y;
            string input;

            ////////////////////////////GATHER DATA\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            Console.WriteLine("enter coordinates V[x,y]:");

            ///x
            Console.WriteLine("x:");
            input = Console.ReadLine();
            x = double.Parse(input); 

            ///y
            Console.WriteLine("y:");
            input = Console.ReadLine();
            y = double.Parse(input);


            ////////////////////////////COMPUTE\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            
            ///A
            line.A.x = line.A.x + x;
            line.A.y = line.A.y + y;

            ///B
            line.B.x = line.B.x + x;
            line.B.x = line.B.x + y;
        }

        public void rotation(LineModel line)
        {
            double Xprim = 0, Yprim = 0, degree;
            int i;
            string input;

            ////////////////////////////GATHER DATA\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            Console.WriteLine("choose: 1-rotation A relative to B, 2-vice versa ");
            input = Console.ReadLine();
            i = int.Parse(input);

            ///degree
            Console.WriteLine("degree: ");
            input = Console.ReadLine();
            degree = double.Parse(input);



            ////////////////////////////COMPUTE\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            switch (i)
            {
                case 1:
                    Xprim = (line.A.x)*Math.Cos(degree) - (line.A.y)*Math.Sin(degree);
                    Yprim = (line.A.y)*Math.Cos(degree) - (line.A.x)*Math.Sin(degree);
                    break;

                case 2:
                    Xprim = (line.B.x) * Math.Cos(degree) - (line.B.y) * Math.Sin(degree);
                    Yprim = (line.B.y) * Math.Cos(degree) - (line.B.x) * Math.Sin(degree);
                    break;

                default: break;
            }
            Console.WriteLine("x':"+Xprim+" y':"+Yprim);
        }

        public void mirror(PointModel point)
        {
            int i;
            string input;

            ////////////////////////////GATHER DATA\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            Console.WriteLine("choose: 1-X axis, 2-Y axis");
            input = Console.ReadLine();
            i = int.Parse(input);


            ////////////////////////////COMPUTE\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            switch (i)
            {
                case 1:
                    point.y = point.y * -1;
                    break;

                case 2:
                    point.x = point.x * -1;
                    break;

                default: break;
            }
        }


        ////////////////////////////////////////// LAB 2
        public void side(PointModel point, LineModel line)
        {
            ////////////////////////////GATHER DATA\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            double[] coefficient = SLE(line);
            double A = coefficient[0]; //a
            int B = -1;
            double C = coefficient[1]; //b


            ////////////////////////////COMPUTE\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            double x = A * point.x + B * point.y + C;

            if (0 > x)
            {
                Console.WriteLine("left side");
            }
            else if (0 < x)
            {
                Console.WriteLine("right side");
            }
            else
            {
                Console.WriteLine("on");
            }
        }

        //public void CrossingPointerCramer(double A1, double B1, double C1, double A2, double B2, double C2)
        //{
        //    double W, Wx, Wy, X, Y;

        //    W = (A1 * B2 - B1 * A2);
        //    Wx = ((-C1) * B2 - B1 * (-C2));
        //    Wy = (A1 * (-C2) - (-C1) * A2);

        //    X = Wx / W;
        //    Y = Wy / W;

        //    Console.WriteLine("crossing point x:" + X + " y:" + Y);
        //}

        public void CrossingPointerCramer(LineModel l1, LineModel l2)
        {
            double W, Wx, Wy, X, Y;
            double[] coefficient;

            ////////////////////////////GATHER DATA\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            coefficient = SLE(l1);
            double A1 = coefficient[0]; //a
            int B1 = -1;
            double C1 = coefficient[1]; //b

            coefficient = SLE(l2);
            double A2 = coefficient[0]; //a
            int B2 = -1;
            double C2 = coefficient[1]; //b


            ////////////////////////////COMPUTE\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            W = (A1 * B2 - B1 * A2);
            Wx = ((-C1) * B2 - B1 * (-C2));
            Wy = (A1 * (-C2) - (-C1) * A2);

            X = Wx / W;
            Y = Wy / W;

            Console.WriteLine("crossing point x:" + X + " y:" + Y);
        }

        public void triangleArea(TriangleModel triangle) 
        {
            PointModel v1 = new PointModel();
            PointModel v2 = new PointModel();
            double P;

            ////////////////////////////GATHER DATA\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            //v1
            v1.x = (triangle.P2.x - triangle.P1.x);
            v1.y = (triangle.P2.y - triangle.P1.y);

            //v2
            v2.x = (triangle.P3.x - triangle.P1.x);
            v2.y = (triangle.P3.y - triangle.P1.y);

            ////////////////////////////COMPUTE\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            P = 0.5 * ((v1.x * v2.y) - (v2.x * v1.y));

            Console.WriteLine("triangles's area: "+P);
        }

        ////////////////////////////////////////// LAB 3
        public double anyFigureArea()
        {
            string input;

            ////////////////////////////GATHER DATA\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
           Console.WriteLine("enter the number of vertices:");
            input = Console.ReadLine();
            int n = int.Parse(input);
            double sum = 0;
            List<PointModel> pointsList = new List<PointModel>();

            for(int i =0; i<n;i++)
            {
                Console.WriteLine("vertice:" + i);
                PointModel point = new PointModel();

                Console.WriteLine("enter point's x coordinate :");
                input = Console.ReadLine();
                point.x = double.Parse(input);

                Console.WriteLine("enter point's y coordinate :");
                input = Console.ReadLine();
                point.y = double.Parse(input);

                pointsList.Add(point);
            }
            pointsList.Add(pointsList[0]); //the last element == first element

            for (int i = 0; i < n; i++)
            {
                PointModel p1 = new PointModel();
                PointModel p2 = new PointModel();

                p1 = pointsList[i];
                p2 = pointsList[i+1];

                sum += ((p1.x * p2.y) - (p2.x * p1.y));

            }

            Console.WriteLine("area:"+ sum * 0.5);
            return sum*0.5;
        }

       

    }
}
