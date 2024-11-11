namespace Abstraction_Demo{
    internal class Rectangle:Shape{
        public int Length { get; set; }
        public int Height { get; set; }
        public Rectangle (string color, int sides, int l, int h):base(color,sides){
            Height = h;
            Length = l;
        }

        public override void Area(){
            System.Console.WriteLine($"Area of Rectangle = {Height*Length}");
        }

        public override void ShowName(){
            System.Console.WriteLine($"Name of shape is {this}");
        }
    }

}