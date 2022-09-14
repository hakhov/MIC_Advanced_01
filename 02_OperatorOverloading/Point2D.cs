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

        public static Point2D operator ++(Point2D point2D)
        {
            Point2D result = new();
            result._x = point2D._x + 1;
            result._y = point2D._y + 1;

            return result;
        }

        public static Point2D operator --(Point2D point2D)
        {
            Point2D result = new();
            result._x = point2D._x - 1;
            result._y = point2D._y - 1;

            return result;
        }

        public static bool operator <(Point2D point1, Point2D point2)
        {
            if (point1._x < point2._x && point1._y < point2._y)
                return true;
            else
                return false;
        }

        public static bool operator >(Point2D point1, Point2D point2)
        {
            if (point1._x > point2._x && point1._y > point2._y)
                return true;
            else
                return false;
        }

        public static bool operator true(Point2D point)
        {
            if (point._x != 0 || point._y != 0)
                return true;
            else
                return false;
        }

        public static bool operator false(Point2D point)
        {
            if (point._x != 0 && point._y != 0)
                return true;
            else
                return false;
        }

        public static Point2D operator |(Point2D point1, Point2D point2)
        {
            if ((point1._x != 0 || point2._y != 0) | (point1._y != 0 || point2._y != 0))
                return new Point2D(1, 1);
            else
                return new Point2D(0, 0);
        }

        public static Point2D operator &(Point2D point1, Point2D point2)
        {
            if ((point1._x != 0 && point2._y != 0) & (point1._y != 0 && point2._y != 0))
                return new Point2D(1, 1);
            else
                return new Point2D(0, 0);
        }

        public static bool operator !(Point2D point)
        {
            if (point) 
                return false;
            else
                return true;
        }

        public static bool operator ^(Point2D point1, Point2D point2)
        {
            if (point1._x > point2._x && point1._y > point2._y)
                return true;
            else
                return false;
        }
    }
}
