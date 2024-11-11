namespace Abstraction_Demo{
    internal class Triangle:Shape{
        public int Base { get; set; }
        public int Height { get; set; }

        public Triangle(string color, int sides, int bs, int height):base(color,sides){
            Base = bs;
            Height = height;
        }

        public override void Area(){
            System.Console.WriteLine($"Area of Triangle = {0.5*Base*Height}");
        }

        public override void ShowName(){
            System.Console.WriteLine($"Name of shape is {this}");
        }
    }
}