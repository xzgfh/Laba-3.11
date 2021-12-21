using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure one, two, three;

            one = new Circle(5);

            one.Print();

            Console.WriteLine("Периметр: " + one.Perimeter() + " Площадь: " + one.Area());

            two = new Triangle(5, 5, 5);

            two.Print();

            Console.WriteLine("Периметр: " + two.Perimeter() + " Площадь: " + two.Area());

            three = new Rectangle(5, 5);

            three.Print();

            Console.WriteLine("Периметр: " + three.Perimeter() + " Площадь: " + three.Area());

            Console.Read();
        }
    }
}
