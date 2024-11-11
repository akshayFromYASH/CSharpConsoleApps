// using System;
// using System.ComponentModel;
// using System.ComponentModel.DataAnnotations;
// using System.Numerics;
// using System.Security.Cryptography;
// using System.Security.Cryptography.X509Certificates;

// namespace InputOutputDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Keywords ==> var, ref, out, params

// when var is used you should must initialize the variable
//             // var x = 10;
//             // var y = 20.34;


//             // Sum(23,21);
//             // Sum(4,5,3);
//             // Sum(35.33,3);
//             // int a = 9, b=11;
//             // Swap(10, 20);
//             // System.Console.WriteLine($"a={a} b={b}");
//             // Swap(ref a, ref b);

//             // int radius = 7, l = 11, b=5;
//             // double ar1;
//             // int ar2;
//             // AreaCircle(ref radius, out ar1);
//             // System.Console.WriteLine($"Area of circle = {ar1:f2}");

//             // AreaRectangle(ref l, ref b, out ar2);
//             // System.Console.WriteLine($"Area of rectangle = {ar2}");


//             // params
//             GetDetails('f',"Meena","Seema","Smita","Gita");
//         }

//         public static void Sum(int a, int b)
//         {
//             System.Console.WriteLine($"Sum = {a + b}");
//         }

//         public static void Sum(int a, int b, int c)
//         {
//             System.Console.WriteLine($"Sum = {a + b + c}");
//         }

//         public static void Sum(double a, int b)
//         {
//             System.Console.WriteLine($"Sum = {a + b}");
//         }

//         public static void Swap(int a, int b)
//         {
//             System.Console.WriteLine($"a={a} b={b}");
//             int temp;
//             temp = a;
//             a = b;
//             b = temp;
//             System.Console.WriteLine($"a={a} b={b}");
//         }

//         public static void Swap(ref int a, ref int b){
//             int temp;
//             temp = a;
//             a = b;
//             b = temp;
//             System.Console.WriteLine($"a={a} b={b}");
//         }


//         public static void AreaCircle(ref int radius,out double a){
//             a = Math.PI*radius*radius;
//         }

//         public static void AreaRectangle(ref int l, ref int b, out int a){
//             a = l*b;   
//         }


//         public static void GetDetails(char g, params string[] names){
//             string gender = "";
//             if(g=='f'){
//                 gender = "Girls";
//             }else{
//                 gender = "Boys";
//             }

//             System.Console.WriteLine($"Here is the list of {names.Length} {gender}");
//             foreach(string name in names){
//                 System.Console.WriteLine(name);
//             }
//         }
//     }
// }