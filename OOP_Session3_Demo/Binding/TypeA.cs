using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3_Demo.Binding
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int _A)
        {
            A = _A;
        }
        public void MyFun01()
        {
            Console.WriteLine("I am Base [Parent]");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA: A = {A}");
        }
    }
}
