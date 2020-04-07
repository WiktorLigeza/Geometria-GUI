using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Models
{
    public class TriangleModel
    {
        public PointModel P1;
        public PointModel P2;
        public PointModel P3;

        /// <summary>
        /// constructor
        /// </summary>
        public TriangleModel()
        {
            P1 = new PointModel();
            P2 = new PointModel();
            P3 = new PointModel();
        }

        public string Display
        {
            get
            {
                return $"P1: {P1.x} {P1.y} , P2: {P2.x} {P2.y} , P3: {P3.x} {P3.y}";
            }
        }
    }
}
