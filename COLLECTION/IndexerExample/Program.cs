// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

namespace IndexerDemo{
    internal class Program{
        public static void Main(string[] args){

            Batch YashBatch = new Batch();

            int n = 101;

            try{
                System.Console.WriteLine(YashBatch[104]);
                System.Console.WriteLine("Id of PJ is: " + YashBatch[104]);
                YashBatch[105] = "Rahul";
                System.Console.WriteLine("Id 105 : Name : "+YashBatch[105]);

            }catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}
