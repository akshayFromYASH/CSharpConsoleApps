namespace InheritanceDemo{
    internal class Cylinder:Circle{
        public int Height { get; set; }

        public Cylinder(){
            Height = 8;
        }

        public Cylinder(int height, int radius, int x, int y):base(radius,x,y){
            Height = height;
        }

        public override void Area(){
            double A = 2*Math.PI*Radius*(Radius+Height);
            System.Console.WriteLine($"Area of Cylinder = {A:f2}");
        }

        public void BaseCircleArea(Circle circle){
            System.Console.WriteLine();
        }
    }
}