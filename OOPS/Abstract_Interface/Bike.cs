namespace Abstract_Interface{
    internal class Bike:Vehicle,IPrintable,IDisplayable{
        public string Type { get; set; }
        public int EngCapacity { get; set; }
        public static bool Gears = true;

        public Bike(string brand, string model, string color, int speed, string type, int engCap):base(brand,model,color,speed){
            Type = type;
            EngCapacity = engCap;
        }

        public static void GearSystem(){
            if(Gears){
                System.Console.WriteLine("Bike has Manual Gear System");
            }
            else{
                System.Console.WriteLine("Bike has auto Gear System");
            }
        }

        public override void ShowSpeed(){
            System.Console.WriteLine($"{this} speed = {Speed} km/hr");
        }

        public void PrintDetails(){
            System.Console.WriteLine($"Print Bike Detials from IPrintable interface: {Brand} {Model} {Color} {Type} {EngCapacity}");
        }

        public void Display(){
            System.Console.WriteLine($"Display Bike Detials: {Brand} {Model} {Color} {EngCapacity}");
        }

        // If two methods of two different interfaces have same name then we use <interface_Name>.<method_name>
        void IDisplayable.PrintDetails(){
            System.Console.WriteLine($"Print Bike Detials from IDisplayable interface: {Brand} {Model} {Color} {Type} {EngCapacity}");
           
        }

    }
}