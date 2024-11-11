namespace IComparable_Interface_Demo{
    internal class Employee:IComparable{
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, decimal salary ){
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString(){
            return $"Employee Details: {Id} {Name} {Salary}";
        }

        public int CompareTo(object? obj){
            Employee e1 = obj as Employee;

            if(this.Id<e1.Id){
                return -1;
            }
            else if(this.Id>e1.Id){
                return 1;
            }
            else{
                return 0;
            }
        }
    }
}