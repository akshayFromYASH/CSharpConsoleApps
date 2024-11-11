// using System.ComponentModel;
// using System.Runtime.CompilerServices;

// namespace Threading{
//     internal class Program6{
//         private static Mutex mutex = new Mutex(false,"Global\\MyUniqueMutexName");
//         public static void Main(string[]args){

//             // Mutex object with a unique name, allowing for cross-process locking
//             if(!mutex.WaitOne(TimeSpan.FromSeconds(3),false)){
//                 System.Console.WriteLine("Another instance of the application is already running");
//                 return; // Exit if another instance is running
//             }
//             try{
//                 System.Console.WriteLine("Application is running. Press enter to exit...");
//                 System.Console.WriteLine(); // Keep the application running
//             }
//             finally{

//                 // release the mutex when
//                 mutex.ReleaseMutex();
//             }
//             Console.Read();
//         }
//     }
// }