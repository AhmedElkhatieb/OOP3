namespace OOP_Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Q1
            // b) To define a blueprint for a class
            #endregion
            #region Q2
            // a) private
            #endregion
            #region Q3
            // b) No
            #endregion
            #region Q4
            // b) Yes, interfaces can inherit from multiple interfaces
            #endregion
            #region Q5
            // none is right we use ':'
            // but if i must choose i choose, i choose
            // d) implements
            #endregion
            #region Q6
            // a) Yes
            #endregion
            #region Q7
            // b) No, all members are implicitly public
            #endregion
            #region Q8
            // b) To provide a clear separation between interface and class members
            #endregion
            #region Q9
            // d) Only if the constructor is static
            #endregion
            #region Q10
            // c) By separating interface names with commas
            #endregion
            #endregion
            #region Part 02
            Circle circle = new Circle(5);
            circle.DisplayShapeInfo();
            Console.WriteLine();
            Rectangle rectangle = new Rectangle(3, 5);
            rectangle.DisplayShapeInfo();
            #endregion
        }
    }
}
