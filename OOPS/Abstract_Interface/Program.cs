namespace Abstract_Interface{
    internal class Program{
        public static void Main(string[] args){
            
            // Car c1 = new Car("BMW","X6","Blue",180, 6000000);

            // c1.ShowSpeed();
            // Car.GearSystem();
            // Car.GearSystem();

            // // Here we give access to object in heap to Interface type
            // // Car class
            // IPrintable Pcar = c1;
            // IDisplayable Dcar = c1;

            // Pcar.PrintDetails();
            // Dcar.Display();
            // Dcar.PrintDetails();

            // // Bike class
            // Bike bike = new Bike("HONDA","Shine","Red",120, "EV", 650);
            // bike.ShowSpeed();
            // Bike.GearSystem();
            // Bike.GearSystem();

            // IPrintable Pbike = bike;
            // IDisplayable Dbike = bike;

            // Pbike.PrintDetails();
            // Dbike.Display();
            // Dbike.PrintDetails();

            CurrentAccount current = new CurrentAccount(7.5f,32000m,101,new Customer(1,"youraj","lambdurg","yourajlambdurg@gmail.com","Solapur Maharastra",703872322,new Date(14,03,2002)));

            SavingAccount saving = new SavingAccount(9.5f,29000m,102,new Customer(2,"Atharvaa","Chavaan","atharvaachavaan@gmail.com","Solapur Maharastra",703872322,new Date(14,03,2002)));

            System.Console.WriteLine();
            System.Console.WriteLine(current);
            current.ShowBalance();
            current.ShowDetails();
            
            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine(saving);
            saving.ShowBalance();
            saving.ShowDetails();
            
        }
    }
}
