using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    public abstract class Figure
    {
        private double _width;
        private double _height;

        public double Width
        {
            get { return _width; }
            set { _width = value < 0 ? -value : value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value < 0 ? -value : value; }
        }

        public string Type { get; set; }

        public Figure()
        {
            Width = Height = 0.0;
            Type = null;
        }

        public Figure(double width, double height, string type)
        {
            Width = width;
            Height = height;
            Type = type;
        }

        public Figure(double x, string type)
        {
            Width = Height = x;
            Type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Width} _ {Height} _ {Type}");
        }

        public abstract double Surface();
        public abstract int MyProperty { get; set; }
    }
}
