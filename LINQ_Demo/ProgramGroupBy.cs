// namespace LINQ_Demo{
//     internal class ProgramGroupBy{
//         static void Main(string[] args){
            
//             var data = Student.GetStudents().GroupBy(g=>g.Gender);

//             foreach(var gp in data){
//                 System.Console.WriteLine(gp.Key + " Count = " + gp.Count());

//                 foreach(var s in gp){
//                     System.Console.WriteLine(s.Name);
//                 }
//             }
//         }
//     }
// }