using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3_Demo.Binding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _A, int _B) : base (_A)
        {
            B = _B;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am Derived [Child]");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"TypeB is: A = {A}, B = {B}"); ;
        }
    }
}
