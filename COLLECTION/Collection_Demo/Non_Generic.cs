// // See https://aka.ms/new-console-template for more information
// using System;
// using System.Collections;
// namespace Collections_Demo
// {
//     internal class NonGeneric

//     // Boxing ==> Process of upgrading/upcasting value type to object type happening when Add() Method
//     // Unboxing ==> Process happens downcasting object type converted to its original value type
//     {
//         static void Main(string[] args)
//         {

//             // Non-Generic Classes ==> 1) ArrayList 
//             System.Console.WriteLine("...... Non-Generic ArrayList ......");
//             ArrayList myarrlist = new ArrayList();

//             // OPERATIONS ON ArrayList ==> 
//             // Add() --> Adds an element to the end of ArrayList
//             myarrlist.Add(10);
//             myarrlist.Add("India");
//             myarrlist.Add(DateTime.Now);
//             myarrlist.Add(true);
//             myarrlist.Add(0.9535);
//             myarrlist.Add(9.70m);
//             myarrlist.Add('r');

//             // Insert() --> Inserts element at a specific index
//             myarrlist.Insert(3, "YASH Technologies");

//             // Remove() --> Removes an element from ArrayList
//             myarrlist.Remove('r');

//             // RemoveAt() --> Removes an element at a specific 
//             myarrlist.RemoveAt(4);

//             // Contains() --> Checks if an element is in the ArrayList
//             myarrlist.Contains('r');

//             // Count() --> Gets the number of elements in ArrayList
//             // Clear() --> Removes all elements from the ArraList


//             foreach (var obj in myarrlist)
//             {
//                 System.Console.WriteLine(obj);
//             }



//             // 2) Stack ==> First in Last out
//             System.Console.WriteLine("\n\n......... Non-Generic Stack ...........");
//             Stack mystack = new Stack();

//             mystack.Push(10);
//             mystack.Push("Yash");
//             mystack.Push(2.34f);
//             mystack.Push(DateTime.Now);
//             mystack.Push(true);

//             // Count is used to get size of collections
//             System.Console.WriteLine("Stach has: " + mystack.Count + " items");

//             try
//             {
//                 System.Console.WriteLine(mystack.Peek());
//                 System.Console.WriteLine(mystack.Pop());
//                 System.Console.WriteLine(mystack.Pop());
//                 System.Console.WriteLine(mystack.Pop());
//                 System.Console.WriteLine(mystack.Pop());
//                 System.Console.WriteLine(mystack.Pop());
//                 System.Console.WriteLine(mystack.Pop());

//             }
//             catch (Exception ex)
//             {
//                 System.Console.WriteLine(ex.Message);
//             }


//             // 3) Queue ==> First in First out
//             System.Console.WriteLine("\n\n......... Non-Generic Queue ...........");
//             Queue myqueue = new Queue();

//             // Enqueue()  is used to add item to Queue
//             myqueue.Enqueue(10);
//             myqueue.Enqueue("Jai Bharat");
//             myqueue.Enqueue(76.33);
//             myqueue.Enqueue('y');


//             // Dequeue() is used to retrieve/remove item from queue
//             System.Console.WriteLine("Data " + myqueue.Dequeue());

//             System.Console.WriteLine(myqueue.Contains("yash"));     // returns true if myqueue contains 


//             // 4) SortedList ==> - Key-Value pairs and sorts the key elements as soon as they are added
//                              // - All keys should be of same datatype other wise it cannot be compared

//             System.Console.WriteLine("............ Non-Generic SortedList ............");
//             SortedList students = new SortedList();

//             students.Add("sub1", 45);
//             students.Add("sub4", 65);
//             students.Add("sub5", 55);
//             students.Add("sub2", 35);
//             students.Add("sub3", 55);

//             foreach (var student in students)
//             {
//                 System.Console.WriteLine($"SortedList : {student}");
//             }


//             // Key in SortedList must be of same data type ==> cant sort by comapring different datatype
//             // SortedList sortedList = new SortedList();
//             // sortedList.Add(10, "value1"); // Key is an int, value is a string
//             // sortedList.Add("key2", true); // Key is a string, value is a bool
//             // sortedList.Add(3.14, 123); // Key is a double, value is an int

//             // foreach (var sorted in sortedList)
//             // {
//             //     System.Console.WriteLine($"SortedList : {sorted}");
//             // }

//         }
//     }
// }
