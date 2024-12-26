using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_3
{
    internal class Circle : ICircle
    {
        public double R { get; set; }
        public double Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("I Am A Circle");
            Console.WriteLine($"My Radius = {R}");
            Area = 3.14 * R * R;
            Console.WriteLine($"My Area = {Area}");
        }
        public Circle(double _R)
        {
            R = _R;
        }
    }
}
