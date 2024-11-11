namespace Abstract_Interface{
    internal class Date{
        
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // default constructor
        public Date()
        {
            Day = 14;
            Month = 03;
            Year = 2002;
        }


        // Parameterized constructor
        public Date(int day, int month, int year){
            Day = day;
            Month = month;
            Year = year;
            
        }

        public void Display(){
            System.Console.WriteLine(Day+"/"+Month+"/"+Year);
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}