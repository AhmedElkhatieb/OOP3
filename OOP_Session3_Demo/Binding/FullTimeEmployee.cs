using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3_Demo.Binding
{
    internal class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }
        public new void MyFun01 ()
        {
            Console.WriteLine("I Am Full Time Employee");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"Employee Id = {Id}, Name is {Name}, Age = {Age}, Salary = {Salary}");
        }
    }
}
