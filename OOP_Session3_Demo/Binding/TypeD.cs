using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3_Demo.Binding
{
    internal class TypeD : TypeC
    {
        public int D { get; set; }
        public TypeD(int _A, int _B, int _C, int _D) : base(_A, _B, _C)
        {
            D = _D;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am Derived [Grand Grand Child]");
        }
        public new virtual void MyFun02()
        {
            Console.WriteLine($"TypeD is: A = {A}, B = {B}, C = {C}, D = {D}"); ;
        }
    }
}
