namespace InheritanceDemo{
    internal class Manager : Employee{
        public decimal Commission {get;set;}
        public int Sales {get;set;}
        public Manager(){
            Commission = 250;
            Sales = 21;
            System.Console.WriteLine("Object of Manager Created....");
        }

        public Manager(decimal commission, int sales, int id, string name, decimal basic):base(id,name,basic){
          Commission = commission;
          Sales = sales;
          System.Console.WriteLine("Object of Manager Created....");
        }

        public override string ToString(){
            return base.ToString() + $"Manager Details:Commission = {Commission} Sales = {Sales}";
        }

        public override decimal GroceSalary(){
            return base.BasicSalary + (Commission*Sales);
        }

    }
}