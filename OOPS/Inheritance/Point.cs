namespace InheritanceDemo{
    internal class Point{
        public int Xcord { get; set; }
        public int Ycord { get; set; }

        public Point(){
            Xcord = 0;
            Ycord = 0;
        }

        public Point(int x, int y){
            Xcord=x;
            Ycord=y;
        }
    }
}