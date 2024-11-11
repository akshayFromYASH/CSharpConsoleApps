// using System.ComponentModel.DataAnnotations;
// using System.Globalization;
// using System.Linq;
// using System.Security.Cryptography;

// namespace LINQ_Demo
// {
//     internal class ProgramWhere
//     {
//         static void Main(string[] args)
//         {
//             // Results from Student.GetStudents()
//             var result = from s in Student.GetStudents() select s;
//             foreach(var student in result){
//                 System.Console.WriteLine(student.ID + " " + student.Name + " " + student.Gender);
//             }
//             System.Console.WriteLine("-----------------List of Girls------------------------------------------");

//             var result1 = from s in Student.GetStudents() where s.Gender == "Female"  select s;
//             foreach(var student in result1){
//                 System.Console.WriteLine(student.ID + " " + student.Name + " ");
//             }
//             System.Console.WriteLine("-------------------List of Boys using Lambda Expression-----------------------------------------");

//             var result2 = Student.GetStudents().Where(s=>s.Gender == "Male" && s.Age>21);
//             foreach(var student in result2){
//                 System.Console.WriteLine(student.ID + " " + student.Name);
//             }
//         }
//     }
// }
