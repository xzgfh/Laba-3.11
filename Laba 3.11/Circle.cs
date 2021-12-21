using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3._11
{
    class Circle : Figure
    {
        private double Radius { get; set; }

        public Circle() : base()

        {

            this.Radius = 5;

        }

        public Circle(double rad) : base("Circle")

        {

            this.Radius = rad;

        }

        public override double Perimeter()

        {

            return 2 * Math.PI * this.Radius;

        }

        public override double Area()

        {

            return Math.PI * this.Radius * this.Radius;

        }
    }
}
