// using System;
// using System.Collections;

// namespace Collections_Demo{
//     internal class HashTableDemo{
//         static void Main(string[] args){

//             // Using HasTable 
//             HashTable ht = new HashTable();

//             ht.Add(1,"Welcome");
//             ht.Add("two",2);
//             ht.Add("three","Yash");

//             System.Console.WriteLine("Key and Value Pairs from ht");

//             foreach(DictionaryEntry ele in ht){
//                 System.Console.WriteLine("{0} and {1}",ele.Key, ele.Value);
//             }

//             HashTable h2 = new HashTable(){
//                 {1,"Hello"},
//                 {2,3232},
//                 {3,230.33},
//                 {4,null}            // Here value can be null but key cannot be null
//             };

//            foreach(var ele in h2.key){
//                 System.Console.WriteLine("{0} and {1}",ele, h2[ele]);
//             }




//         }
//     }
// }