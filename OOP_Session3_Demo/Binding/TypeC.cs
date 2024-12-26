using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3_Demo.Binding
{
    internal class TypeC : TypeB
    {
        public int C { get; set; }
        public TypeC(int _A, int _B, int _C) : base(_A, _B)
        {
            C = _C;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am Derived [Grand Child]");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"TypeC is: A = {A}, B = {B}, C = {C}"); ;
        }
    }
}
