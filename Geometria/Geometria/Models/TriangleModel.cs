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

    }
}
