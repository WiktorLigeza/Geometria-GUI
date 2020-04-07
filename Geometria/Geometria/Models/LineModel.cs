using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Models
{
    public class LineModel
    {
        /// <summary>
        /// Lines A point - PointModel
        /// </summary>
        public PointModel A;

        /// <summary>
        /// Lines B point - PointModel
        /// </summary>
        public PointModel B;


        /// <summary>
        /// constructor
        /// </summary>
        public LineModel()
        {
            A = new PointModel();
            B = new PointModel();
        }


        public string Display
        {
            get
            {
                return $"A: {A.x} {A.y} ,B: {B.x} {B.y}";
            }
        }
    }
}
