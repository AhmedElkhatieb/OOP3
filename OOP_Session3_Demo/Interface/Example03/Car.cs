using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3_Demo.Interface.Example03
{
    internal class Car : Veichle, IMovable
    {
        public void Backward()
        {
            Console.WriteLine("Car moves backward");
        }

        public void Forward()
        {
            Console.WriteLine("Car moves Forward");
        }
    }
}
