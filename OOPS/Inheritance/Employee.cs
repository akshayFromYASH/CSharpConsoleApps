namespace InheritanceDemo{
    internal class Employee{
        public int Id {get;set;}
        public string Name {get;set;}
        public decimal BasicSalary {get;set;}

        public Employee(){
            Id =1;
            Name = "bill";
            BasicSalary = 20000;
            System.Console.WriteLine("Object of Employee created");
        }

        public Employee(int id, string name, decimal basic){
            Id = id;
            Name = name;
            BasicSalary = basic;
            System.Console.WriteLine("Object of Employee created");
        }

        public override string ToString(){
            return $"Employee Details: {Id} {Name} {BasicSalary}";
        }

        public virtual decimal GroceSalary(){
            return BasicSalary;
        }

        public static void NetSalary(Employee employee){
            System.Console.WriteLine($"Net Salary = {employee.GroceSalary()-500}");
        }
    }
}