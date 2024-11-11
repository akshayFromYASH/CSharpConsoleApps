namespace Abstraction_Demo{
    internal class Circle:Shape{
        public int Radius { get; set; }

        public Circle(string color, int sides, int radius):base(color,sides){
            Radius = radius;
        }

        public override void Area(){
            System.Console.WriteLine($"Area of Circle = {Math.PI*Radius*Radius}");
        }

        public override void ShowName(){
            System.Console.WriteLine($"Name of shape is {this}");
        }
    }
}