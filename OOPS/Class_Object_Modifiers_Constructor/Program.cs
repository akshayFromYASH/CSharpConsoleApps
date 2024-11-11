using System;
using System.Diagnostics;

namespace Class_Object_Modifiers_Constructor
{
    // internal ==> accessible within the same namespace / assembly
    class Program
    {
        public static void Main(string[] args)
        {
        //    Employee emp = new(1101240,"Akshay Mashale",2232.00m, Employee.Department.Accounts, new Date(23,23,3233));

        //    System.Console.WriteLine(emp);

            Product prod = new Product();

            Product[] prodArray = new Product[4];

            prodArray[0] = new Product(1,"Tshirt","Levis",499,Product.Category.Clothing,new Date(12,3,2022),new Date(23,5,2027));
            prodArray[1] = new Product(2,"ChaiPatti","Red Label",249,Product.Category.Grocery,new Date(12,3,2022),new Date(23,5,2023));
            prodArray[2] = new Product(3,"Smartphone","Samsung",69999,Product.Category.Electronic,new Date(12,3,2022),new Date(23,5,2027));
            prodArray[3] = new Product(4,"Washing Machine","Godrej",14999,Product.Category.Electric,new Date(12,3,2022),new Date(23,5,2027));

            foreach (Product product in prodArray){
                System.Console.WriteLine(product);
            }


            // Object class is standard class in .net 
            // It has four methods
            // 1. ToString() 
            // 2. Equals()
            // 3. GetType()
            // 4. GetHashType()

            System.Console.WriteLine(prod.GetType());  // ==> Returns the type of object i.e. class name
            System.Console.WriteLine(prod.GetHashCode());
            Product prod1 = new Product();

            System.Console.WriteLine(prod.Equals(prod1));

            System.Console.WriteLine(Employee.count);
            System.Console.WriteLine(Product.count2);

            System.Console.WriteLine(Employee.showCount());
            System.Console.WriteLine(Product.showCount());

        }
    }
}
