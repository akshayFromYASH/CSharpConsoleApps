namespace Abstract_Interface{
    internal class Car:Vehicle,IPrintable,IDisplayable{
        public decimal Price { get; set; }

        public static bool Gears = true;

        public static void GearSystem(){
            if(Gears){
                System.Console.WriteLine("{Car has Manual Gear System}");
            }
            else{
                System.Console.WriteLine("Car is auto gears");
            }
        }

        public Car(string brand, string model, string color, int speed, int price):base(brand,model,color,speed){
            Price = price;
        }

        public override void ShowSpeed(){
            System.Console.WriteLine($"{this} speed = {Speed} km/hr");
        }

        public void PrintDetails(){
            System.Console.WriteLine($"Print Car Detials from IPrintable interface: {Brand} {Model} {Color} {Price}");
        }

        public void Display(){
            System.Console.WriteLine($"Display Car Detials: {Brand} {Model} {Color} {Price}");
        }

        void IDisplayable.PrintDetails(){
            System.Console.WriteLine($"Print Car Detials from IDisplayable interface: {Brand} {Model} {Color} {Price}");
           
        }

    }
}