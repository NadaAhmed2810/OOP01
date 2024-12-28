using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    internal struct Point
    {
        public double x;
        public double y;
       public  Point()
        {
            x = y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static double CalcDistince(Point p, Point p1)
        {
            double dist = Math.Sqrt(Math.Pow(p1.x - p.x, 2) + Math.Pow(p1.y - p.y, 2));
            return dist;
        }
    }
}
