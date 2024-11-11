// See https://aka.ms/new-console-template for more information

namespace IComparable_Interface_Demo{
    internal class Program{
        public static void Main(string[] args){

            Employee[] employees = new Employee[4];

            employees[0] = new Employee(103,"Akshay Mashale", 27000);
            employees[1] = new Employee(102,"Prathmesh Jagtap ", 87000);
            employees[2] = new Employee(104,"Youraj Lambdurg", 29000);
            employees[3] = new Employee(101,"Prabhav Khalya", 72000);

            Array.Sort(employees);

            foreach (var employee in employees){
                System.Console.WriteLine(employee);
            }

            Product[] prod = new Product[4];

            prod[0] = new Product(1,"Tshirt",20,499);
            prod[1] = new Product(2,"Jeans",30,999);
            prod[2] = new Product(3,"Shoes",20,1999);
            prod[3] = new Product(4,"Jacket",40,1499);

            Array.Sort(prod);
            
            foreach (var prd in prod){
                System.Console.WriteLine(prd);
            }
        }
    }
}
