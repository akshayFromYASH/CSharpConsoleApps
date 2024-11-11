namespace InheritanceDemo{
    internal class Circle:Point{
        public int Radius { get; set; }

        public Circle(){
            Radius = 10;
        }

        public Circle(int radius, int x, int y):base(x,y){
            Radius = radius;
        }

        public virtual void Area(){
            double A = Math.PI*Radius*Radius;
            System.Console.WriteLine($"Area of Circle = {A:f2}");
        }
    }
}