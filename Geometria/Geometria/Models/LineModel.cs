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
        /// Line's A point - PointModel
        /// </summary>
        public PointModel A;

        /// <summary>
        /// Line's B point - PointModel
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
    }
}
