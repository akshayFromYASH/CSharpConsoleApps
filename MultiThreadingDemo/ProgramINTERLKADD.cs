// using System.Diagnostics.Tracing;

// namespace Threading{
//     internal class programINTERLKADD{
//         private static int counter = 0;

//         static void Main(string[] args){
//             Thread[] threads = new Thread[10];

//             ParameterizedThreadStart obj = new ParameterizedThreadStart(IncrementCounter);

//             for(int i = 0; i<threads.Length; i++){
//                 threads[i] = new Thread(obj);
//                 threads[i].Start(5);
//             }

//             foreach(Thread t in threads){
//                 t.Join();
//             }
//             System.Console.WriteLine($"Final counter Value {}");
//         }

//         static void IncrementCounter(object Value){
//             for(int i=0; i<1000; i++){
//                 Interlocked.Add(ref counter,(int))
//             }
//         }
//     }
// }