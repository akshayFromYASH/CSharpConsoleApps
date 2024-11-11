// namespace Threading{
//     internal class Program{
//         static void Main(string[]args){
//             Thread T = Thread.CurrentThread;
//             T.Name = "Main Thread";
//             System.Console.WriteLine("Main Thread is working");

//             Thread t1 = new Thread(DisplayNumbers);

//             t1.Name = "thread1";
//             t1.Start();
            
//         }

//         public static void DisplayNumbers(){

//             for(int i=1;i<=10;i++){
//                 Thread.Sleep(1000);
//                 System.Console.WriteLine(i);
//             }
//         }
//     }
// }
