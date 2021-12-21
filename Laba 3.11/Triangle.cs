using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3._11
{
    class Triangle : With_Vertices
    {
        private double A { get; set; }

        private double B { get; set; }

        private double C { get; set; }

        public Triangle() : base()

        {

            this.A = 5;

            this.B = 5;

            this.C = 5;

        }

        public Triangle(double one, double two, double three) : base("Triangle", 3)

        {

            this.A = one;

            this.B = two;

            this.C = three;

        }

        public override double Perimeter()

        {

            return this.A + this.B + this.C;

        }

        public override double Area()

        {

            double p = (this.A + this.B + this.C) / 2;

            return Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));

        }
    }
}
