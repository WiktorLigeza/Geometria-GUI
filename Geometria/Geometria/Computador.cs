using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria.Models;

namespace Geometria
{
    /// <summary>
    /// GUI
    /// </summary>
    public class Computador
    {
        ////////////////////////////////////////// LAB 1
        /// <summary>
        /// straight line equation tab[0] = a, tab[1] = b
        /// </summary>
        /// <param name="line"></param>
        public double[] SLE(LineModel line)
        {
            double a, b;
            double[] result = new double[2];
            a = (line.A.y - line.B.y) / (line.A.x - line.B.x); //(y1 - y2) / (x1 - x2);
            b = line.A.y - a * line.A.x;  //y1 - a * x1;
            //Console.WriteLine("equation: y=" +a+"x+"+b);
            result[0] = a;
            result[1] = b;

            return result;
        }

        public LineModel vector(LineModel line,double x, double y)
        {
            ///A
            line.A.x = line.A.x + x;
            line.A.y = line.A.y + y;

            ///B
            line.B.x = line.B.x + x;
            line.B.x = line.B.x + y;

            return line;
        }

        public LineModel rotation(LineModel line,double degree, bool terms)
        {

            if (terms)
            {
                line.A.x = (line.A.x) * Math.Cos(degree) - (line.A.y) * Math.Sin(degree);
                line.A.y = (line.A.y) * Math.Cos(degree) - (line.A.x) * Math.Sin(degree);
            }
            else
            {
                line.A.x = (line.B.x) * Math.Cos(degree) - (line.B.y) * Math.Sin(degree);
                line.A.y = (line.B.y) * Math.Cos(degree) - (line.B.x) * Math.Sin(degree);
            }
          
            return line;
        }

        public PointModel mirror(PointModel point, int axis)
        {
            if(axis == 0)
            {
                point.x = point.x * -1;
            }
            else point.y = point.y * -1;

            return point;
        }


        ////////////////////////////////////////// LAB 2
   
        public PointModel CrossingPointerCramer(LineModel l1, LineModel l2)
        {
            double W, Wx, Wy, X, Y;
            double[] coefficient;
            PointModel output = new PointModel();

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

            output.x = X;
            output.y = Y;

            return output;
        }

        public double triangleArea(TriangleModel triangle)
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

            return P;
        }

        ////////////////////////////////////////// LAB 3
        public double anyFigureArea(int n, List<PointModel> pointsList )
        {
            double sum = 0;
            pointsList.Add(pointsList[0]); //the last element == first element

            for (int i = 0; i < n; i++)
            {
                PointModel p1 = new PointModel();
                PointModel p2 = new PointModel();

                p1 = pointsList[i];
                p2 = pointsList[i + 1];

                sum += ((p1.x * p2.y) - (p2.x * p1.y));

            }

            return sum * 0.5;
        }

    }
}
