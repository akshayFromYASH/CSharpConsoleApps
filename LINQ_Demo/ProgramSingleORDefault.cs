// namespace LINQ_Demo{
//     internal class PrgramSingleORDefault{
//         static void Main(string[] args){
            
//             int[] numbers = {12,2,3,10,4,5,67,89,7,23,14,90,21};

//             try{
//                 // Single() ==> if it doesnt get any matching results it will throw exception
//                 // var data = numbers.Single(n=>n>100);

//                 // SingleOrDefault ==> Doesnt throw exception it returns the default value for datatype
//                             // - e.g for int 0, for fload and double 0.0, for string null
//                 var data = numbers.SingleOrDefault(n=>n>100);
//                 System.Console.WriteLine(data);
//             }
//             catch(Exception ex){
//                 System.Console.WriteLine(ex.Message);
//             }
//         }
//     }
// }