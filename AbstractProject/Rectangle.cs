using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    public class Rectangle : Figure
    {
        public override int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Rectangle(double w, double h)
            : base(w, h, "Զուգահեռագիծ")
        {

        }
        public Rectangle(double w, double h, string type)
            : base(w, h, type)
        {

        }

        public Rectangle(double w)
            : base(w, "Քառակուսի")
        {

        }

        public bool IsSquare()
        {
            if (Width == Height) return true;

            return false;
        }
        public override double Surface()
        {
            return Width * Height;
        }
    }
}
