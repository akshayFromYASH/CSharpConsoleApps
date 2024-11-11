// using System.Net.Http.Headers;

// namespace Threading{
//     internal class Program5{
//         static void Main(string[]args){
//             Numbers num = new Numbers();

//             ThreadStart delobj = new ThreadStart(num.Display1to10);
//             ParameterizedThreadStart obj = new ParameterizedThreadStart(DisplayNumbers);
//             Thread t2 = new Thread(obj);
//             Thread t1 = new Thread(delobj);
//             t1.Start();
//             t2.Start(10);
//             t1.Join();
//             t2.Join();

//         }

//         static void DisplayNumbers(object n){
//             for(int i = 0; i<(int)n;i++){
//                 Thread.Sleep(1000);
//                 System.Console.WriteLine("Method: " + i);
//             }
//         }
//     }
// }