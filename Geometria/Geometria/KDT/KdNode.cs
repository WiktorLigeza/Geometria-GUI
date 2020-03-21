using Geometria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Geometria.KDT
{
    public class KDNode
    {
        //value
        public PointModel point;

        public KDNode left;
        public KDNode right;

       public double distance(PointModel goal)
        {
            Vector A = new Vector(this.point.x, this.point.y);
            Vector B = new Vector(goal.x, goal.y);
            Vector AB = A - B;
            return AB.Length;
        }

    }
}
