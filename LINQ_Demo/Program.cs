// using System.Globalization;
// using System.Linq;

// namespace LINQ_Demo{
//     internal class Program{
//         static void Main(string[]args){

//             // // LINQ on array
//             int[] numbers = {70,1,2,3,4,5,23,67,45,600,59,91};
//             // var result1 = from n in numbers orderby n select n;
//             // foreach(var n in result1){
//             //     System.Console.WriteLine(n);
//             // }

//             string[] words = {"One","Two","Three","Four","Five","Six","Seven","Eight","Nine"}; 
//             // var result2 = from w in words where w[1]=='i' select w;
//             // foreach(var w in result2){
//             //     System.Console.WriteLine(w);
//             // }

//             // // Reverse() ==> results of the query will be reversed
//             // var result3 = (from w in words where w[1]=='i' select w).Reverse();
//             // foreach(var w in result3){
//             //     System.Console.WriteLine(w);
//             // }

//             // // StartsWith() ==> Results that start with the given letters
//             // // EndsWith() ==> Results that start with the given letters
//             // // Contains() ==> Results that contains the given letters
//             // string[] musicians = {"Ashok Kumar","Kishore Kumar","Asha Bhosale","Lata Mangeshkar","Sonu Nigam"};
//             // var result4 = from m in musicians where m.StartsWith("As") select m;
//             // foreach(var m in result4){
//             //     System.Console.WriteLine(m);
//             // }


//             // // Distinct() ==>
//             // // Union() ==>  All elements from 2 arrays
//             // // Intersect() ==> Common elements in 2 arrays
//             // // Except() ==> Elements present in A but not in B (works like left join)
//             int[] numA = {12,3,4,7,5,0,1,6,8};
//             int[] numB = {1,2,3,4,10,5,6,7,9};

//             // System.Console.WriteLine("------------ Union of 2 arrays -----------------");
//             // var result5 = numA.Union(numB);
//             // foreach(var n in result5){
//             //     System.Console.WriteLine(n);
//             // }

//             // System.Console.WriteLine("------------ Intersect of 2 arrays -----------------");
//             // var result6 = numA.Intersect(numB);
//             // foreach(var n in result6){
//             //     System.Console.WriteLine(n);
//             // }

//             // System.Console.WriteLine("------------ Except of 2 arrays -----------------");
//             // var result7 = numA.Except(numB);
//             // foreach(var n in result7){
//             //     System.Console.WriteLine(n);
//             // }

//             string[] cities = {"Mumbai","Pune","Mumbai","Indore","Hyderabad","Bangalore"};
//             // var result8 = cities.Distinct();
//             // System.Console.WriteLine("--------------- Distinct City Names --------------------");
//             // foreach(var c in result8){
//             //     System.Console.WriteLine(c);
//             // }


//             // // AGGREGATE functions
//             // int sum = numbers.Sum();
//             // System.Console.WriteLine("Sum of Elements: " + sum);
//             // int max = numbers.Max();
//             // System.Console.WriteLine("Max of Elements: " +max);
//             // int min = numbers.Min();
//             // System.Console.WriteLine("Mini of Elements: " +min);
//             // double avg = numbers.Average();
//             // System.Console.WriteLine("Average of Elements: " +avg);
//             // int count = numbers.Count();
//             // System.Console.WriteLine("Count of Elements: " +count);


//             // Any() ==> Uses lambda expression and returns boolean value if expression is true even once 
//                     // - Works like or operator
//             string[] Words = {"Believe","Relief","Receive","Chief"};
//             bool IAfterE = Words.Any(w=>w.Contains("ei"));
//             System.Console.WriteLine(IAfterE);

//             // All() ==> If every elements follows the lambda expression then returns true
//                     // - Works like and operator
//             bool EAfterI = Words.All(w=>w.Contains("ie"));
//             System.Console.WriteLine(EAfterI);
//         }
//     }
// }
