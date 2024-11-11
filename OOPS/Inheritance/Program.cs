

// Access Modifiers ==>
                // 1. Public --> - Accessed from anywhere within diff classes, assemblies, external applications
                            //  - Most permissive access modifiers
                // 2. Private --> - Members accessed within the same class or derived classes in same assembly
                            //  - Member functions cant be accessed outside class but by calling it in other public fn or constructor we can access its implementation
                // 3. Protected --> - Only accessed within the parent class and its child classes
                // 4. Internal --> - Accessed only inside the current assembly


namespace InheritanceDemo{
    internal class Program{
    public static void Main(string[] args){
        // Employee emp = new Employee();
        // Manager mng = new Manager();

        // System.Console.WriteLine(emp);
        // System.Console.WriteLine(mng);
        // System.Console.WriteLine(emp.GroceSalary());
        // System.Console.WriteLine(mng.GroceSalary());
        // Employee.NetSalary(emp);
        // Employee.NetSalary(mng);

        // Peacock p1 = new("Wild Peacock","Green Blue", 14);
        // p1.Voice();


        //Early-binding and Late-binding
        Circle c1 = new();
        c1.Area();
        Cylinder cy1 = new();
        cy1.Area();

        //Shadowing
        Circle C = cy1;
        C.Area();

    }
    }
}
