using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3._11
{
    abstract class With_Vertices : Figure
    {
        public readonly int Vert;

        public With_Vertices()

        {

            this.Vert = 0;

        }

        protected With_Vertices(string _name, int vert) : base(_name)

        {

            this.Vert = vert;

        }

        public override void Print()

        {

            Console.WriteLine("Название фигуры: " + Name + " " + "Количество вершин" + Vert);

        }
    }
}
