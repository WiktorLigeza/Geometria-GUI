using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Models
{
    public class CircleModel
    {
         /// <summary>
        /// Circles center point - PointModel
        /// </summary>
        public PointModel center;

        /// <summary>
        /// radious
        /// </summary>
        public double r;

        public CircleModel()
        {
            center = new PointModel();
        }


        public string Display
        {
            get
            {
                return $"Cnter: {center.x} {center.y}, r: {r} ";
            }
        }
    }
}
