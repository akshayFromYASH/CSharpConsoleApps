// // See https://aka.ms/new-console-template for more information
// using System;
// using System.Collections;
// using System.ComponentModel;
// namespace Collections_Demo
// {
//     internal class Generic
//     {
//         static void Main(string[] args)
//         {
//             // Generic classes ==> 1) List

//             System.Console.WriteLine("......... Generic List ..........");
//             List<string> fruits = new List<string>();

//                 // Operations on List ==> - Elements can be accessed by index
//                 // Add() --> Adds elements to the end of the list
//             fruits.Add("Apple");
//             fruits.Add("Samsung");
//             fruits.Add("Orange");
//             fruits.Add("Grapes");
//             fruits.Add("Mango");

//                 // Insert() --> Inserts and element at specific index
//             fruits.Insert(3,"Mango");

//                 // Remove() --> Removes an element from the list
//             fruits.Remove("Samsung");

//                 // RemoveAt() --> Removes and element at a specific index
//             fruits.RemoveAt(4);

//                 // Contains() --> Checks if an element exists in the list
//             fruits.Contains("Banana");

//                 // Sort() --> Sorts the elements in the list using a specified comparer
//             fruits.Sort();

//                 // BinarySearch() --> Searches for an element and return index of that element
//             fruits.BinarySearch("Apple");
//                 // Clear() --> Removes all elements from the list
//             // fruits.Clear();


//             System.Console.WriteLine("... List of fruits ...");
//             foreach(var fruit in fruits){
//                 System.Console.WriteLine(fruit);
//             }

//             fruits.Sort();
//             System.Console.WriteLine("... List of Sorted fruits ...");
//             foreach(var fruit in fruits){
//                 System.Console.WriteLine(fruit);
//             }
            

//             List <Student> subjects = new List<Student>();

//             subjects.Add(new Student(1,"Akshay",30));
//             subjects.Add(new Student(2,"Yuraj",40));
//             subjects.Add(new Student(3,"Rahul",10));
//             subjects.Add(new Student(4,"Rohan",20));

//             System.Console.WriteLine("......Student List .......");

//             foreach(var stud in subjects){
//                 System.Console.WriteLine(stud);
//             }

//             subjects.Sort();
//             System.Console.WriteLine("......Sorted Student List .......");

//             foreach(var stud in subjects){
//                 System.Console.WriteLine(stud);
//             }


//             // 2) Stack ==> - Last In First Out
            
//             System.Console.WriteLine("............ Stack ............");
//             Stack<string> genStack = new Stack<string>();

//                 // Operations on Stack
//                 // Push() --> Adds an element to the top of the Stack
//             genStack.Push("Book1");
//             genStack.Push("Book2");
//             genStack.Push("Book3");
//             genStack.Push("Book4");
//             genStack.Push("Book5");

//             System.Console.WriteLine("........ Book Stack Before Pop.......");
//             foreach(var book in genStack){
//                 System.Console.WriteLine(book);
//             }


//                 // Pop() --> Removes and returns the top element from the stack
//             System.Console.WriteLine(genStack.Pop());
//             System.Console.WriteLine(genStack.Pop());


//                 // Peek() --> Returns the top element without removing it
//             System.Console.WriteLine("........ Book Stack After Pop.......");
//             foreach(var book in genStack){
//                 System.Console.WriteLine(book);
//             }  
//                 // Count() --> Gets the number of elements in the stack
//                 // Clear() --> Removes all elements from the stack


//             // 3) Queue ==> First In First Out
//             System.Console.WriteLine("............ Queue .............");
//             Queue<int> quantity = new Queue<int>();

//                 // Enqueue() --> Adds an element to the end of the queue
//             quantity.Enqueue(25);
//             quantity.Enqueue(35);
//             quantity.Enqueue(15);
//             quantity.Enqueue(10);
//             quantity.Enqueue(40);

//             System.Console.WriteLine("........ Quantity Queue Before Dequeue.......");
//             foreach(var quant in quantity){
//                 System.Console.WriteLine(quant);
//             }

//                 // Dequeue() --> Removes and returns the element at the front of the queue.
//             quantity.Dequeue();
//             quantity.Dequeue();
//             quantity.Dequeue();
//             System.Console.WriteLine("........ Quantity Queue After Dequeue.......");
//             foreach(var quant in quantity){
//                 System.Console.WriteLine(quant);
//             }

//                 // Peek() --> Returns the element at the front of the queue without removing it
//             System.Console.WriteLine("Element at the Top "+quantity.Peek());

            
//             // 4) SortedList ==> -  Key-Value pairs and sorts the key elements as soon as they are added
//                              // - All keys should be of same datatype other wise it cannot be compared
//             System.Console.WriteLine("............ Generic SortedList ............");
//             SortedList<string,int> MarkSheet = new SortedList<string, int>();

//             MarkSheet.Add("sub1", 45);
//             MarkSheet.Add("sub4", 65);
//             MarkSheet.Add("sub5", 55);
//             MarkSheet.Add("sub2", 35);
//             MarkSheet.Add("sub3", 55);

//             foreach (var marks in MarkSheet)
//             {
//                 System.Console.WriteLine($"SortedList : {marks}");
//             }

//                 // Remove() --> Removes key-value pair with the specified key
//             MarkSheet.Remove("sub2");

//                 //RemoveAt() --> Removes the key-value pair at the specified index
//             MarkSheet.RemoveAt(2);

//                 // ContainsKey() --> checks if SotedList contains key
//                 // ContainsValue() --> checks if SortedList contains a value
//             MarkSheet.ContainsKey("sub1");
//             MarkSheet.ContainsValue(55);

//                 // IndexOfKey() --> Returns the index of the key in the SortedList
//                 // IndexOfValue() --> Returns the index of the value in the SortedList
//             MarkSheet.IndexOfKey("sub2");
//             MarkSheet.IndexOfValue(35);

//             IEnumerator enumerator = MarkSheet.GetEnumerator();
//             System.Console.WriteLine("Enumerator to print values.......");
//             while(enumerator.MoveNext()){
//                 string marks = (string)enumerator.Current;
//                 System.Console.WriteLine(marks);
//             }


                // 5) SortedDictionay ==> just like dictionary but gets sorted on adding new entries based on key
                // 6) SortedSet ==> Doesnt have key-value pair, Duplicate values are not allowed
            
//         }
//     }
// }
