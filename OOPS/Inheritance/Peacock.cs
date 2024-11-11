namespace InheritanceDemo{
    internal class Peacock: Bird {
        public string Type;

        public Peacock(string type, string color, int weight):base(weight,color){

        }
        
        public override void Voice(){
            System.Console.WriteLine("Birds voide is pihu pihu... ");
        }
    }
}