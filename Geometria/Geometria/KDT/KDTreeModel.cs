using Geometria.KDT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Geometria.Models
{
    public class KDTreeModel
    {
        private KDNode root = new KDNode();
        
        /// <summary>
        /// creates Kd tree from PointModel list
        /// </summary>
        /// <param name="list"></param>
        public void createKDT(List<PointModel> list)
        {
            int i = 1;
            foreach(PointModel point in list)
            {
                root = insertKDT(point,root,i);
            }
        }

        /// <summary>
        /// finds nearest PointModel to a given PointModel
        /// </summary>
        /// <param name="goal"></param>
        /// <returns></returns>
        public PointModel findNearest(PointModel goal)
        {
            int i = 1;
            KDNode result = findTheNearestNeighbor(goal, this.root, null, i);
            return result.point;
        }



        ///////////////////////////////COMPUTE\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private KDNode insertKDT(PointModel point, KDNode node,int i) 
        {
            //set root
            if (node == null)
            {
                node = new KDNode();
                node.point = point;
            }
            else if (i == 0) // for x axis
            {
                if (point.x < node.point.x)
                {
                    node.left = insertKDT(point, node.left, (i + 1) % 2);
                }
                else node.right = insertKDT(point, node.right, (i + 1) % 2);
            }
            else // for y axis
            {
                if (point.y < node.point.y)
                {
                    node.left = insertKDT(point, node.left, (i + 1) % 2);
                }
                else node.right = insertKDT(point, node.right, (i + 1) % 2);
            }
           

            return node;
        }

       private KDNode findTheNearestNeighbor(PointModel goal, KDNode root,KDNode best, int i)
        {
            KDNode goodSide = new KDNode();
            KDNode badSide = new KDNode();
            if (root == null)
            {
                return best;
            }
            if (best == null || root.distance(goal) < best.distance(goal))
            {
                best = root;
            }
            if (i == 0) // for x axis
            {
                if (goal.x < root.point.x)
                {
                    goodSide = root.left;
                    badSide = root.right;
                }
                else
                {
                    goodSide = root.right;
                    badSide = root.left;
                }
            }
            else // for y axis
            {
                if (goal.y < root.point.y)
                {
                    goodSide = root.left;
                    badSide = root.right;
                }
                else
                {
                    goodSide = root.right;
                    badSide = root.left;
                }
            }
            best = findTheNearestNeighbor(goal, goodSide, best, (i + 1) % 2);
            if (isItWorthIt(goal,badSide,best,i))
            {
                best = findTheNearestNeighbor(goal, goodSide, best, (i + 1) % 2);
            }

            return best;
        }

       private bool isItWorthIt(PointModel goal, KDNode node, KDNode best,int i)
        {
            if (node != null)
            {
                if (i == 0) // for x axis
                {
                    if (Math.Abs(node.point.x - goal.x) < best.distance(goal))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else // for y axis
                {
                    if (Math.Abs(node.point.y - goal.y) < best.distance(goal))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else return false;
        }

        /// <summary>
        /// constructor
        /// </summary>
        public KDTreeModel()
        {
            root = null;
        }
    }
}
