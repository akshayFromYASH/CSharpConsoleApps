namespace Class_Object_Modifiers_Constructor{
    public class Employee{
        public enum Department
        {
            IT = 101,HR, Accounts, Electrical, Civil
        }
        public int EmpId { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Department Dept {get;set;}
        public Date doj {get;set;}

        public static int count{get;set;}

        public Employee()
        {
            EmpId = 1101240;
            Name = "Akshay";
            Salary = 3434;
            Dept = Department.IT;
            doj = new Date();
            count++;
        }

        public Employee(int id, string name, decimal salary, Department dept, Date doj){
            EmpId = id;
            Name = name;
            salary = Salary;
            this.Dept = dept;
            count++;
        }

        public override string ToString()
        {
            return $"Employee Details: {EmpId} {Name} {Salary} {Dept} {doj}";
        }

        public static int showCount(){
            return count;
        }
    }
}