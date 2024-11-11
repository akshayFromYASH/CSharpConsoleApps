// namespace LINQ_Demo{
//     internal class ProgramSelectMany{
//         static void Main(string[] args){
//             // SelectMany operator

//             var result = Student1.GetStudents().SelectMany(p=>p.Programming);
//             System.Console.WriteLine("------------- Programming languages are ------------------");
//             foreach(string p in result.Distinct()){
//                 System.Console.WriteLine(p+ ",");
//             }
//         }
//     }
// }