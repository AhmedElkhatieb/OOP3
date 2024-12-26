using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_3
{
    internal class Rectangle : IRectangle
    {
        public double Length { get ; set ; }
        public double Width { get ; set ; }
        public double Area { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("I Am A Rectangle");
            Console.WriteLine($"My Length = {Length}");
            Console.WriteLine($"My Width = {Width}");
            Area = Length * Width;
            Console.WriteLine($"My Area = {Area}");
        }
        public Rectangle(double _Length, double _Width)
        {
            Length = _Length;
            Width = _Width;
        }
    }
}
