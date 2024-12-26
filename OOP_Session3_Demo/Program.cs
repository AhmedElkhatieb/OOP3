using OOP_Session3_Demo.Binding;
using OOP_Session3_Demo.Interface;
using OOP_Session3_Demo.Interface.Example03;

namespace OOP_Session3_Demo
{
    

    internal class Program
    {
        //public static void ProcessEmployee(FullTimeEmployee employee)
        //{
        //    if (employee != null)
        //    {
        //        employee.MyFun01();
        //        employee.MyFun02();
        //    }
        //}
        //public static void ProcessEmployee(PartTimeEmployee employee)
        //{
        //    if (employee != null)
        //    {
        //        employee.MyFun01();
        //        employee.MyFun02();
        //    }
        //}
        public static void ProcessEmployee(Employee employee)
        {
            if (employee != null)
            {
                employee.MyFun01(); // Static Binding (I Am Employee)
                employee.MyFun02(); // Dynamic Binding
            }
        }

        #region Inteface
        //public static void Print10NumbersFromSeries(SeriesByTwo Series)
        //{
        //    if (Series != null)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine($"{Series.Current}\t");
        //            Series.GetNext();
        //        }
        //        Series.Reset();
        //        Console.WriteLine();
        //    }
        //}
        //public static void Print10NumbersFromSeries(SeriesByThree Series)
        //{
        //    if (Series != null)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine($"{Series.Current}\t");
        //            Series.GetNext();
        //        }
        //        Series.Reset();
        //        Console.WriteLine();
        //    }
        //}
        public static void Print10NumbersFromSeries(ISeries Series)
        {
            if (Series != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{Series.Current}\t");
                    Series.GetNext();
                }
                Series.Reset();
                Console.WriteLine();
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Binding
            #region What Is Binding
            // Binding is a behaviour 
            // Reference from parent, object from child
            //TypeA RefBase = new TypeB(1, 2);
            //RefBase.A = 11;
            ////RefBase.B = 20; // Invalid (Reference from A only see attributes belonging to TypeA)
            //RefBase.MyFun01(); //I am base [Parent]
            //RefBase.MyFun02(); // TypeB is: A =11, B = 2

            // MyFun01 was with new keyword => Static Binding [Early Binding]
            // Compiler will bind function call based on reference not object
            // at compilation time

            // MyFun02 was with overriding (virtual at parent) => Dynamic Binding [Late Binding]
            // CLR will bind function call based on object not reference
            // At Runtime

            #region What is not binding
            //TypeA typeA;
            //typeA = new TypeA(1);
            //typeA = new TypeB(1, 2); // Binding
            ////typeA = new TypeC(1, 2, 3); // If typeC exist and inheriting from typeB => Binding
            //TypeB typeB = (TypeB)typeA; // Casting not binding
            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B)
            #endregion
            #region Binding is Behaviour
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            //fullTimeEmployee.Id = 10;
            //fullTimeEmployee.Name = "Rana";
            //fullTimeEmployee.Age = 22;
            //fullTimeEmployee.Salary = 10000;
            //ProcessEmployee(fullTimeEmployee);

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 10,
            //    Name = "Rana",
            //    Age = 22,
            //    HourRate = 120
            //};
            //ProcessEmployee(partTimeEmployee);
            #endregion
            #region Example
            TypeA typeA = new TypeC(1, 2, 3);
            typeA.A = 10;
            //typeA.B = 20; // Invalid
            //typeA.C = 30; // Invalid
            //typeA.MyFun01(); // Static Binding
            //typeA.MyFun02(); // Dynamic Binding

            TypeB typeB = new TypeC(1, 2, 3);
            //typeB.A = 10;
            //typeB.B = 20;
            //typeB.MyFun01(); 
            //typeB.MyFun02();

            //TypeA typeA1 = new TypeE(1, 2, 3, 4, 5); // Indirect Parent
            //TypeB typeB1 = new TypeE(1, 2, 3, 4, 5); // Indirect Parent
            //TypeC typeC1 = new TypeE(1, 2, 3, 4, 5); // Indirect Parent

            //Console.WriteLine("Before Breaking the chain");
            //typeA1.MyFun02(); // Type C is : 
            //// will print the last apperance of the function (before new virtual)
            //typeB1.MyFun02();
            //typeC1.MyFun02();

            //Console.WriteLine("After breaking the chain");
            //TypeD typeD1 = new TypeE(1, 2, 3, 4, 5); // Direct Parent
            //typeD1.MyFun02();
            //// Starting from Type D, a new chain began
            //TypeD typeD2 = new TypeD(1, 2, 3, 4); // Direct Parent
            //typeD2.MyFun02();

            #endregion
            #endregion
            #endregion
            #region Interface
            // عقد بين 2 ديفيلوبرز واحد بيكتبه والتاني بيمضي عليه
            // لاحظت ان فيه مجموعة من الفانكشن بتتكرر بنفس الاسم بس البودي مختلف
            // signature only
            // عقد عشان الانترفيس لو جواه 3 فانكشن ف ال هيعملو امبليمينت لازم ينفذ ال 3
            IMyType myType;
            // Declare reference of type IMyType refering to null
            // This reference can refer to a class or a struct implementing IMyType
            // CLR will allocate 4 bytes at stack for the reference
            //myType = new IMyType(); // invalid (can not create object from interface)
            //MyType myType1 = new MyType();
            //myType1.Salary = 10000;
            //myType1.MyFun();
            //myType1.Print(); // Invalid (the default implemented method is shown only in 1 case)
            // the case is reference from interface object from class
            //IMyType ReferenceFromInteface = new MyType();
            //ReferenceFromInteface.Print();

            #region Example 02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree);

            //SeriesByFour seriesByFour = new SeriesByFour();
            //Print10NumbersFromSeries(seriesByFour);
            #endregion
            #region Example 03
            //Airplane airplane = new Airplane();
            //airplane.Forward // Invalid because there is 2 backward functions
            // the refernce must be from interface
            IMovable movable = new Airplane();
            movable.Backward();
            IFlyable flyable = new Airplane();
            flyable.Backward();


            #endregion
            #endregion
        }
    }
}
