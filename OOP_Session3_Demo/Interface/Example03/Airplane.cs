using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3_Demo.Interface.Example03
{
    internal class Airplane : Veichle, IMovable, IFlyable
    {
        void IMovable.Backward()
        {
            Console.WriteLine("Airplane move on ground backward");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("Airplane Fly backward");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("Airplane move on ground froward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane Fly forward");
        }
    }
}
