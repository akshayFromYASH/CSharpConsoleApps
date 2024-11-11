namespace InheritanceDemo{
    internal class Bird{
        public int Weight { get; set; }
        public string Color { get; set; }

        public Bird(){
            Weight = 4;
            Color = "Green";
        }

        public Bird(int weight, string color){
            Color = color;
            Weight = weight;
        }

        public virtual void Voice(){
            System.Console.WriteLine("Birds Voice...");
        }
    }
}