using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3_Demo.Binding
{
    internal class TypeE : TypeD
    {
        public int E { get; set; }
        public TypeE(int _A, int _B, int _C, int _D, int _E) : base(_A, _B, _C, _D)
        {
            E = _E;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am Derived [Grand Grand Grand Child]");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"TypeE is: A = {A}, B = {B}, C = {C}, D = {D}, E = {E}"); ;
        }
    }
}
