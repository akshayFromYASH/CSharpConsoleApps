namespace Abstraction_Demo{
     abstract internal class Shape{
        public int Sides{get;set;}
        public string Color{get;set;}

        public Shape(string color, int sides){
            color = Color;
            sides = Sides;
        }
        
        public abstract void Area();
        public abstract void ShowName(); 
    }
}