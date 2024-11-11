// using System;
// using System.Collections.Generic;
// using System.Collections.ObjectModel;

// namespace Collections_Demo{
//     internal class DictionaryDemo {
//         static void Main(string[] args){

//             Dictionary<int,string> myDict = new Dictionary<int, string>();

//             myDict.Add(1,"Welcome");
//             myDict.Add(2,"to");
//             myDict.Add(3,"Yash Technologies");

//             System.Console.WriteLine("....... Our Dictionary .....");
//             foreach(KeyValuePair<int,string> ele in myDict){
//                 System.Console.WriteLine($"{ele.Key} --> {ele.Value}");
//             }

//             Dictionary<string, string> books = new Dictionary<string, string>(){
//                 {"book1","I dare"},
//                 {"book2","Yugandhar"},
//                 {"book3",null}
//             };

//             // System.Console.WriteLine("....... Our Dictionary 2.....");
//             // foreach(var ele in books){
//             //     System.Console.WriteLine($"{ele} {books[ele]}");
//             // }
//         }
//     }
// }