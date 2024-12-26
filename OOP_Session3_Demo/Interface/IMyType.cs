using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3_Demo.Interface
{
    // First Developer
    internal interface IMyType
    {
        // Default access modifier in inteface is public
        // Private isnt allowed

        // What can we write in interface
        //1- signature for properties
        public int Salary { get; set; }
        //2- Signature for methods
        public void MyFun();
        //3- Default Implemented Method (From C#8 [.Net core 3.1 2019])
        public void Print()
        {
            Console.WriteLine("Hello I am Default Method");
        }
    }
}
