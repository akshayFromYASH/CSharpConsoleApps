// See https://aka.ms/new-console-template for more information
namespace Abstraction_Demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle("orange", 4, 3, 4);
            rect.Area();

            Circle circle = new Circle("Red",0,5);
            circle.Area();

            Triangle tri = new Triangle("yellow", 4, 3, 4);

            Shape[] ShapeArray = new Shape[3];

            ShapeArray[0] = rect;
            ShapeArray[1] = circle;
            ShapeArray[2] = tri;
           

            foreach(var shape in ShapeArray){
                shape.Area();
            }

            int num = 42;
            object boxed = num;

            // int unboxed = (int) boxed;
            int unboxed = Convert.ToInt32(boxed);
            System.Console.WriteLine(unboxed);
            
        }
    }
}
