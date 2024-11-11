// using System.ComponentModel;
// using System.Reflection;

// // Write a class student write a method getresult by passing integer marks as parameter and show the ruslt if he is passed or fail depending on the marks
// // call this method using refleciton invoke method for 5 students

// namespace ReflectionDemo{

//     static class MyClass{
//         public static void Inform(string parameter){
//             System.Console.WriteLine($"Student_Name: {parameter}");
//         }

//     }
//      class MethodInfoDemo{
//         static void Main(string[] args){

//             // // Call it with each of these parameters
//             // string[] parameters = {"Raj","Ratan","PJ","Akshay","Vishal"};
//             // // Get MethodInfo
//             // Type type1 = typeof(MyClass);               // Gets the type of MyClass class
//             // MethodInfo info = type1.GetMethod("Inform");         // MyClass.Inform(parameter)

//             // // foreach is used to Invoke the 
//             // foreach(string parameter in parameters){
//             //     info.Invoke(null, new object[] {parameter});        // Invoke() takes two arguements one is object of class and array as object
//             // }


//             // ASSIGNMENT ANSWER ===> 

//             // Fetching members of Student class in t using Reflection class Type
//             Type t = typeof(Student);

//             // Fetching constructor of Student class in construct using Reflection class ConstructorInfo
//             ConstructorInfo costruct = t.GetConstructor(new[] {typeof(int)});       // GetConstructor() takes parameters same as constructor of Student class in object form

//             int[] marks = {91,88,95,78,86};

//             // Declaring array of objects of type object
//             object[] objects = new object[5];


//             for(int i = 0; i<objects.Length;i++){
//                 // Create a new object of a specified type costruct and assign it to the i-th element of the objects array
//                 objects[i] = costruct.Invoke(new object[] {marks[i]});
//             }

//             // MethodInfo ==> Contains metadata about a method Including its name, return type, parameters, and other attributes.
//             // Used to retrieve a MethodInfo object representing the GetResult method of a given type t
//             MethodInfo Result = t.GetMethod("GetResult");

//             foreach(object obj in objects){
//                 // System.Console.WriteLine(obj);

//                 // Calls the Invoke method on the MethodInfo object Result.
//                 Result.Invoke(obj,null);
//             }

//         }
//     }
// }