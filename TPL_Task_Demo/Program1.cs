// namespace TPL_Task_Demo{
//     internal class Program1{

//         static async Task Main(string[]args){
//             System.Console.WriteLine("Starting calculations......");

//             // Start a tas asynchronously
//             Task<int> calculationTask = PerformCalculationAsync(10);

//             // You can do other work here while calculation is running
//             System.Console.WriteLine("Doing other work while waiting for calculation to complete...");

//             // Await the result of the asynchronous task
//             int result = await calculationTask;

//             System.Console.WriteLine($"Calculation Result: {result}");
//         }

//         static async Task<int> PerformCalculationAsync(int number){
//             await Task.Delay(2000);
//             return number*number;
//         }
//     }
// }
