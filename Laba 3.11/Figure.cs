using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3._11
{
    abstract class Figure
    {
        public readonly string Name;

        public Figure()

        {

            this.Name = "Figure";

        }

        protected Figure(string _name)

        {

            this.Name = _name;

        }

        public virtual void Print()

        {

            Console.WriteLine("Название фигуры: " + Name + " ");

        }

        public abstract double Perimeter();

        public abstract double Area();

    }
}
