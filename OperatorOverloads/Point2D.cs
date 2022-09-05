using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloads
{
    public class Point2D
    {
        private int _x;
        private int _y;

        public Point2D(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Point2D()
        {

        }

        public void ShowInfo()
        {
            Console.WriteLine(_x + "\t" + _y);
        }

        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            Point2D point = new();
            point._x = 20;//point1._x + point2._x;
            point._y = 50;//point1._y + point2._y;

            return point;
        }

        public static Point3D operator +(Point2D point1, Point3D point2)
        {
            Point3D point = new();
            //point._x = 20;//point1._x + point2._x;
            //point._y = 50;//point1._y + point2._y;

            return point;
        }
    }
}
