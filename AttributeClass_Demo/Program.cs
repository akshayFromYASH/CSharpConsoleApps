// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.AccessControl;

namespace Attribute_Class_Demo{
    internal class Program{
        static void Main(string[] args){
            Student s = new Student();
            Type t = s.GetType();

            System.Console.WriteLine("Name of class from obj s " + s.GetType());
            System.Console.WriteLine("Name of class from obj s "+ t);
            
            
            var classAttribute = (MyCustomAttribute)Attribute.GetCustomAttribute(t,typeof(MyCustomAttribute));

            if(classAttribute != null){
                System.Console.WriteLine("Custom Attribute: "+ classAttribute.DeveloperName);
                System.Console.WriteLine("Custom Attribute: "+ classAttribute.Version);
            }
            
            System.Console.WriteLine("-------------------");
            MethodInfo method = t.GetMethod("ShowResult");

            var methodAttribute = (MyCustomAttribute)Attribute.GetCustomAttribute(method,typeof(MyCustomAttribute));

            if(methodAttribute!=null){
                System.Console.WriteLine($"Method Developer Company: {methodAttribute.DeveloperName}");
                System.Console.WriteLine($"Method Developer Company: {methodAttribute.Version}");

            }

            System.Console.WriteLine("----------------------");
        }
    }
}
