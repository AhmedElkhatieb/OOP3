using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3_Demo.Interface
{
    internal class MyType : IMyType // Implement the interface (not inherite)
    {
        public int Salary { get ; set ; }

        public void MyFun()
        {
            Console.WriteLine("Hello World");
        }
    }
}
