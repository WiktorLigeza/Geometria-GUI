using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Models
{
    public class PointModel
    {
        /// <summary>
        /// points x coordinate
        /// </summary>
        public double x;

        /// <summary>
        /// points y coordinate
        /// </summary>
        public double y;

        public string Display
        {
            get
            {
                return $"x: {x}  , y:{y}";
            }
        }
    }
}
