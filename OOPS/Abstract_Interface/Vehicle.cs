namespace Abstract_Interface{
    abstract internal class Vehicle{
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }

        public Vehicle(string brand, string model, string color, int speed){
            Brand = brand;
            Model = model;
            Color = color;
            Speed = speed;
        }

        public abstract void ShowSpeed();
    }
}