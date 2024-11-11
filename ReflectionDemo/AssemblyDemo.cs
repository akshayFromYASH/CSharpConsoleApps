
// using System.Reflection;

// namespace ReflectionDemo{
//     internal class AssemblyDemo{
//         static void Main(string[] args){

//             // Declares an array of type MethodInfo 
//             MethodInfo[] methods;

//             // Declares an array fo type Type
//             Type[] types = new Type[2];

//             try{

//                 // Loads assembly from the specified path
//                 Assembly asm = Assembly.LoadFrom(@"D:\\myLibrary.dll");

//                 // Retrieves all types defined within the assembly and stores it in types array
//                 types = asm.GetTypes();             // All classes 

//                 // Iterates through type object in types array
//                 foreach(Type t in types){
//                     System.Console.WriteLine("class Names" + t.FullName);

//                     // Iterates through every method in type object
//                     foreach(MethodInfo m in t.GetMethods()){
//                         System.Console.WriteLine($"Method Name: {m.Name}");
//                     }
//                 }
//             }catch(Exception ex){
//                 System.Console.WriteLine(ex.Message);
//             }

//         }
//     }
// }
