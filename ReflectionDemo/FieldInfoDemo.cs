using System.ComponentModel;
using System.Reflection;

namespace ReflectionDemo{
    internal class FieldInfoDemo{
        static void Main(string[] args){
            
            // gets the type of Person class 
            Type personType = typeof(Person);
            Type carType = typeof(Car);

            // BindingFlags.NonPublic ==> specifies that field can be non-public 
            // BindingFlags.Instance ==> specifies that fields belongs to an instance of the class
            FieldInfo nameField = personType.GetField("_name", BindingFlags.NonPublic | BindingFlags.Instance);
            System.Console.WriteLine($"Field Name : {nameField.Name}");

            PropertyInfo ageProperty = personType.GetProperty("Age", BindingFlags.NonPublic | BindingFlags.Instance);
            System.Console.WriteLine($"Property Name : {ageProperty.Name}");

            MethodInfo sayHelloMethod = personType.GetMethod("SayHello", BindingFlags.NonPublic | BindingFlags.Instance);
            System.Console.WriteLine($"Method Name : {sayHelloMethod.Name}");
        }
    }
}