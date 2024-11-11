using System.Globalization;

namespace TPL_Task_Demo{
    internal class Program2{
        static async Task Main(string[]args){
            System.Console.WriteLine("Starting Tasks...");

            // Start multiple tasks concurrently
            Task<int> task1 = Task.Run(()=>PerformCalculation(10));
            Task<int> task2 = Task.Run(()=>PerformCalculation(20));
            Task<int> task3 = Task.Run(()=>PerformCalculation(30));

            //wait for all tasks to complete and gather their results
            int[] results = await Task.WhenAll(task1,task2,task3);

            //Process the results
            foreach(int result in results){
                System.Console.WriteLine(result);
            }

        }

        static int PerformCalculation(int num){
            int result = num*num;
            Task.Delay(2000);
            System.Console.WriteLine($"Calculated square of {num} as {result}");
            return result;
        }
    }
}