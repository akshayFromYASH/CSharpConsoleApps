// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System.Reflection.Metadata;

namespace Reflection_CreatInstance_Runtime{
    public class Program{
        public static void Main(string[]args){
            Type t = typeof(TestClass);

            MethodInfo[] methods = t.GetMethods();      // methods is a name of array MethodInfo

            foreach(MethodInfo m in methods){
                System.Console.WriteLine(m.Name);
            }
            
            ConstructorInfo ctor = t.GetConstructor(System.Type.EmptyTypes);

            MethodInfo m1 = t.GetMethod("TestMethod");

            object obj = ctor.Invoke(null);

            System.Console.WriteLine("ans1 = " + m1.Invoke(obj,new object[] {10}));

            // call Add method run time

            object[] parameters = {20,30};

            MethodInfo m2 = t.GetMethod("Add");
            System.Console.WriteLine("Add Method Answer : Ans 2 = "+m2.Invoke(obj,parameters));
        }
    }
}
