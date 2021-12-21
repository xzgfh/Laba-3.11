using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3._11
{
    class Rectangle : With_Vertices
    {
        private double A { get; set; }

        private double B { get; set; }

        public Rectangle() : base()

        {

            this.A = 5;

            this.B = 5;

        }

        public Rectangle(double one, double two) : base("Rectangle", 4)

        {

            this.A = one;

            this.B = two;

        }

        public override double Perimeter()

        {

            return this.A * 2 + this.B * 2;

        }

        public override double Area()

        {

            return this.A * this.B;

        }
    }
}
